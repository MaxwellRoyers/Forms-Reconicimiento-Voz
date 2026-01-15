using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppReconocimientoVoz
{
        public partial class FormDictado : Form
    {
        private SpeechRecognitionEngine recognizer;

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
                return;
            }

            // Gramática de dictado libre
            DictationGrammar dictado = new DictationGrammar();
            recognizer.LoadGrammar(dictado);

            // Agregar comando de cierre "hey reco volver"
            Choices comandosVoz = new Choices("hey reco volver");
            GrammarBuilder gb = new GrammarBuilder(comandosVoz);
            Grammar g = new Grammar(gb);
            recognizer.LoadGrammar(g);

            recognizer.SpeechRecognized += DictadoReconocido;
            recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void DictadoReconocido(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence < 0.40)
                return;

            string texto = e.Result.Text.ToLower();

            // Comando para cerrar el formulario
            if (texto == "hey reco volver")
            {
                recognizer?.RecognizeAsyncStop();
                this.Close();
                return;
            }

            // Dictado normal
            Invoke(new Action(() =>
            {
                txtDictado.AppendText(e.Result.Text + " ");
            }));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            recognizer?.RecognizeAsyncStop();
            base.OnFormClosing(e);
        }
    }
}
