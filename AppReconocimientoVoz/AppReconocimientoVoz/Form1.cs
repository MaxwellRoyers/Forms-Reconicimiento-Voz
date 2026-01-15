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
        private bool activado = false; // Para “Hey reco”

        public Form1()
        {
            InitializeComponent();
            InicializarReconocimiento();
            ActualizarEstado("Inactivo");
        }

        private void InicializarReconocimiento()
        {
            recognizer = new SpeechRecognitionEngine(new CultureInfo("es-ES"));

            try
            {
                recognizer.SetInputToDefaultAudioDevice();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No se detectó ningún micrófono.");
                return;
            }

            // Lista de comandos incluyendo "hey reco" y "ver historial de comandos"
            Choices comandos = new Choices(
                "hola reco",
                "cambiar color rojo",
                "cambiar color azul",
                "limpiar texto",
                "ocultar texto",
                "mostrar texto",
                "ver historial de comandos",
                "abrir dictado",
                "salir"
            );

            Grammar grammar = new Grammar(comandos);
            recognizer.LoadGrammar(grammar);

            recognizer.SpeechRecognized += Reconocido;
            recognizer.RecognizeCompleted += (s, e) => escuchando = false;

            // Ocultar historial por defecto
            lstHistorial.Visible = false;
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
                string comando = e.Result.Text.ToLower();
                string hora = DateTime.Now.ToString("HH:mm:ss");
                lstHistorial.Items.Insert(0, $"{hora} - {comando}");

                lblComando.Text = comando;

                //Si no está activado, solo activamos con "hola reco"
                if (!activado)
                {
                    if (comando == "hola reco")
                    {
                        activado = true;
                        ActualizarEstado("Activado, esperando comando...");
                        if (e.Result.Text == "cambiar color rojo")
                        {
                        this.BackColor = Color.Red;
                        }
                        else if (e.Result.Text == "cambiar color azul")
                        {
                            this.BackColor = Color.Blue;
                        }
                        else if (e.Result.Text == "limpiar texto")
                        {
                            lblComando.Text = string.Empty;
                        }
                        else if (e.Result.Text == "ocultar texto")
                        {
                            lblComando.Visible = false;
                        }
                        else if (e.Result.Text == "mostrar texto")
                        {
                            lblComando.Visible = true;
                        }
                        else if (e.Result.Text == "ver historial de comandos")
                        {
                            MessageBox.Show(string.Join(Environment.NewLine, lstHistorial.Items.Cast<string>()), "Historial de Comandos");
                        }
                        else if (e.Result.Text == "abrir dictado")
                        {
                            FormDictado fd = new FormDictado();
                            fd.Show();
                        }
                        else if (e.Result.Text == "salir")
                        {
                           Application.Exit();
                        }
                    }
                    return; // Ignorar otros comandos hasta que diga “hola reco”
                }
                // 3️⃣ Reiniciar activación
                activado = false;
                ActualizarEstado("Escuchando...");
            }));
        }

        private void ActualizarEstado(string texto)
        {
            lblEscuchando.Text = texto;
        }
    }
}
