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

            // Agregar comando de cierre "reco vuelve"
            Choices comandosVoz = new Choices("reco vuelve");
            Grammar g = new Grammar(comandosVoz);
            recognizer.LoadGrammar(g);

            recognizer.SpeechRecognized += DictadoReconocido;
            recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void DictadoReconocido(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence < 0.70)
                return;

            string texto = e.Result.Text.ToLower();

            // Comando para cerrar el formulario
            if (texto == "reco vuelve")
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
