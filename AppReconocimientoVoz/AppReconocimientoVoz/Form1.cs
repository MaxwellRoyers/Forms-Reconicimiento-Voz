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
    public partial class Form1 : Form
    {
        private SpeechRecognitionEngine recognizer;
        private bool escuchando = false;

        public Form1()
        {
            InitializeComponent();
            InicializarReconocimiento();
            ActualizarEstado("Inactivo");
        }
        private void InicializarReconocimiento()
        {
            recognizer = new SpeechRecognitionEngine(new CultureInfo("es-ES"));
            recognizer.SetInputToDefaultAudioDevice();

            Choices comandos = new Choices(
                "cambiar color rojo",
                "cambiar color azul",
                "limpiar texto",
                "ocultar texto",
                "mostrar texto",
                "salir"
            );

            GrammarBuilder gb = new GrammarBuilder(comandos);
            Grammar grammar = new Grammar(gb);
            recognizer.LoadGrammar(grammar);

            recognizer.SpeechRecognized += Reconocido;
            recognizer.RecognizeCompleted += (s, e) => escuchando = false;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!escuchando)
            {
                recognizer.RecognizeAsync(RecognizeMode.Multiple);
                escuchando = true;
                ActualizarEstado("Escuchando...");
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            if (escuchando)
            {
                recognizer.RecognizeAsyncStop();
                ActualizarEstado("Detenido");
            }
        }

        private void Reconocido(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Confidence < 0.60)
                return;

            Invoke(new Action(() =>
            {
                lblComando.Text = e.Result.Text;

                switch (e.Result.Text)
                {
                    case "cambiar color rojo":
                        this.BackColor = Color.LightCoral;
                        break;

                    case "cambiar color azul":
                        this.BackColor = Color.LightBlue;
                        break;

                    case "limpiar texto":
                        lblComando.Text = string.Empty;
                        break;

                    case "ocultar texto":
                        lblComando.Visible = false;
                        break;

                    case "mostrar texto":
                        lblComando.Visible = true;
                        break;

                    case "salir":
                        Application.Exit();
                        break;
                }
            }));
        }

        private void ActualizarEstado(string texto)
        {
            lblEscuchando.Text = texto;
        }
    
    }
}
