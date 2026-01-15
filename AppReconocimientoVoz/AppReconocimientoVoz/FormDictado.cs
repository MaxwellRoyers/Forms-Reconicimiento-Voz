using System;
using System.Globalization;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace AppReconocimientoVoz
{
    public partial class FormDictado : Form
    {
        private SpeechRecognitionEngine recognizer;
        private string textoAcumulado = ""; // Guarda todo el dictado

        public FormDictado()
        {
            InitializeComponent();
            InicializarDictado();
        }

        private void InicializarDictado()
        {
            recognizer = new SpeechRecognitionEngine(new CultureInfo("es-ES"));

            try
            {
                recognizer.SetInputToDefaultAudioDevice();
            }
            catch
            {
                MessageBox.Show("No se detectó micrófono.");
                Close();
                return;
            }

            // SOLO dictado libre
            recognizer.UnloadAllGrammars();
            recognizer.LoadGrammar(new DictationGrammar());

            // Configurar timeouts para frases más cortas
            recognizer.EndSilenceTimeout = TimeSpan.FromMilliseconds(300);
            recognizer.EndSilenceTimeoutAmbiguous = TimeSpan.FromMilliseconds(500);

            // Eventos
            recognizer.SpeechRecognized += DictadoReconocido;
            recognizer.SpeechHypothesized += DictadoHipotetico; // texto parcial en txtDictado

            // Iniciar reconocimiento
            recognizer.RecognizeAsync(RecognizeMode.Multiple);
            ActualizarEstado("Escuchando...");
        }

        // Cuando se confirma el dictado (frase completa)
        private void DictadoReconocido(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence < 0.40)
                return;

            Invoke(new Action(() =>
            {
                textoAcumulado += e.Result.Text + " ";
                txtDictado.Text = textoAcumulado;
                txtDictado.SelectionStart = txtDictado.Text.Length; // mantener scroll al final
                ActualizarEstado("Escuchando...");
            }));
        }

        // Mientras hablas, muestra texto parcial en txtDictado
        private void DictadoHipotetico(object sender, SpeechHypothesizedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                txtDictado.Text = textoAcumulado + e.Result.Text; // parcial + acumulado
                txtDictado.SelectionStart = txtDictado.Text.Length; // scroll al final
            }));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            try
            {
                ActualizarEstado("Cerrando...");
                recognizer?.RecognizeAsyncCancel();
                recognizer?.Dispose();
            }
            catch { }

            base.OnFormClosing(e);
        }

        private void ActualizarEstado(string texto)
        {
            lblEscuchando.Text = texto;
        }
    }
}
