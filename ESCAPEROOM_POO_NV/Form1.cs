using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESCAPEROOM_POO_NV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CargarAcertijos();

            pnlDialogo.MouseClick += (s, e) => GestionarClickDialogo();
            lblDialogo.MouseClick += (s, e) => GestionarClickDialogo();
            pxbOsaka.MouseClick += (s, e) => GestionarClickDialogo();
        }

        private Queue<DialogosConImagen> secuenciaDialogos = new Queue<DialogosConImagen>();
        List<GestorAcertijo> listaAceLogica = new List<GestorAcertijo>();
        bool interruptor = true;
        string respuestaUsuario;
        int Puntuacion;
        int indiceActual;
        int TiempoDeJuego = 60;
        int fallos;
        bool empezarAcertijo = true;
        int escena = 0;

        #region Navegacion Mause/Teclado
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pnlDialogo.Visible)
            {
                if (e.KeyCode == Keys.S || e.KeyCode == Keys.D) { this.ProcessTabKey(true); return; }
                if (e.KeyCode == Keys.W || e.KeyCode == Keys.A) { this.ProcessTabKey(false); return; }
            }

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (pnlDialogo.Visible)
                {
                    if (timer1.Enabled)
                    {
                        timer1.Stop();
                        lblDialogo.Text = fraseActual;
                    }
                    else
                    {
                        AvanzarDialogo();
                    }
                }
            }
        }

        private void btnConfiguracion_Enter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BringToFront();
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.White;
        }

        private void btnJugar_Enter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BringToFront();
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.White;
        }

        private void btnSalir_Enter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BringToFront();
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.White;
        }

        private void btnSalir_Leave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.FlatAppearance.BorderSize = 0;
        }

        private void btnJugar_Leave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.FlatAppearance.BorderSize = 0;
        }

        private void btnConfiguracion_Leave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.FlatAppearance.BorderSize = 0;
        }

        //

        private void btnJugar_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Focus();
        }

        private void btnConfiguracion_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Focus();
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Focus();
        }

        //

        private void GestionarClickDialogo()
        {
            if (pnlDialogo.Visible)
            {
                if (timer1.Enabled)
                {
                    timer1.Stop();
                    lblDialogo.Text = fraseActual;
                    conteoLetras = fraseActual.Length;
                }
                else
                {
                    AvanzarDialogo();
                }
            }
        }

        #endregion

        #region DialogosNV
        public struct DialogosConImagen
        {
            public string Texto;
            public Image Imagen;

            public DialogosConImagen(string texto, Image imagen)
            {
                Texto = texto;
                Imagen = imagen;
            }
        }

        private void EscenaIntroduccion()
        {
            secuenciaDialogos.Clear();
            secuenciaDialogos.Enqueue(new DialogosConImagen("....", Properties.Resources.OSAKASMOKEGIF));
            secuenciaDialogos.Enqueue(new DialogosConImagen("Holaaa!!", Properties.Resources.oSAKASMILE1));
            secuenciaDialogos.Enqueue(new DialogosConImagen("Alfin llega alguien, que emocion!!", Properties.Resources.OSAKATALK));
            secuenciaDialogos.Enqueue(new DialogosConImagen("Resuelve varios acertijos rapidamente para que pueda salir de aq..", Properties.Resources.OSAKATALK));
            secuenciaDialogos.Enqueue(new DialogosConImagen("P-p.. perdon! para que puedas salir de aqui JJaja..", Properties.Resources.OSAKATALK));
            secuenciaDialogos.Enqueue(new DialogosConImagen("....", Properties.Resources.oSAKASMILE1));
            secuenciaDialogos.Enqueue(new DialogosConImagen("Empiezemos...", Properties.Resources.OSAKATALK));
        }

        private void SelectorDeEscena(int indiceAtual)
        {
            switch (indiceAtual)
            {
                case 0:
                    secuenciaDialogos.Clear();
                    secuenciaDialogos.Enqueue(new DialogosConImagen("¨Si me nombras, desaparezco.¨", Properties.Resources.OSAKATALK));
                    secuenciaDialogos.Enqueue(new DialogosConImagen("Quien o que soy?", Properties.Resources.OSAKATALK));
                    secuenciaDialogos.Enqueue(new DialogosConImagen("....", Properties.Resources.OSAKATALK));
                    break;
            }
        }

        private void AvanzarDialogo()
        {
            if (secuenciaDialogos.Count > 0)
            {
                DialogosConImagen faseActual = secuenciaDialogos.Dequeue();

                if (faseActual.Imagen != null) pxbOsaka.Image = faseActual.Imagen;

                IniciarEfectoTexto(faseActual.Texto);
            }
            else if (empezarAcertijo)
            {
                SelectorDeEscena(indiceActual);

                empezarAcertijo = false;

                AvanzarDialogo();
            }
            else
            {
                MostrarInterfazRespuesta();
            }
        }

        private void MostrarInterfazRespuesta()
        {
            btnOpcion1.Visible = true;
            btnOpcion1.Enabled = true;
            btnOpcion2.Visible = true;
            btnOpcion2.Enabled = true;
            btnOpcion3.Visible = true;
            btnOpcion3.Enabled = true;
            AsignarRespuestas();
        }

        private string fraseActual = "";
        private int conteoLetras = 0;

        private void IniciarEfectoTexto(string texto)
        {
            fraseActual = texto;
            conteoLetras = 0;
            lblDialogo.Text = "";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (conteoLetras < fraseActual.Length)
            {
                lblDialogo.Text += fraseActual[conteoLetras];
                conteoLetras++;
            }
            else
            {
                timer1.Stop();
            }
        }
        #endregion

        private void DesactivarBotonesMenu()
        {
            if (interruptor)
            {
                btnSalir.Visible = false;
                btnConfiguracion.Visible = false;
                btnJugar.Visible = false;
                lblTituloJuego.Visible = false;
                btnSalir.Enabled = false;
                btnConfiguracion.Enabled = false;
                btnJugar.Enabled = false;
            }
            else
            {
                btnSalir.Visible = true;
                btnConfiguracion.Visible = true;
                btnJugar.Visible = true;
                lblTituloJuego.Visible = true;
                btnSalir.Enabled = true;
                btnConfiguracion.Enabled = true;
                btnJugar.Enabled = true;
            }

            interruptor = !interruptor;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            using (FormSalir ventanaSalir = new FormSalir())
            {
                if (ventanaSalir.ShowDialog() == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            DesactivarBotonesMenu();

            EscenaIntroduccion();

            pnlDialogo.Visible = true;
            lblDialogo.Visible = true;
            lblDialogo.Enabled = true;

            this.Focus();

            AvanzarDialogo();
        }

        private void pnlDialogo_Paint(object sender, PaintEventArgs e)
        {
            using (Pen penBlanco = new Pen(Color.White, 3))
            {
                e.Graphics.DrawRectangle(penBlanco, 10, 10, pnlDialogo.Width - 20, pnlDialogo.Height - 20);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

       

        private void CargarAcertijos()
        {
            //acertijo de logica
            listaAceLogica.Add(new GestorAcertijo("Si me nombras, desaparezco. ¿Quién soy?", "silencio", "La ausencia de ruido"));
        }

        private void AsignarRespuestas()
        {
            switch(indiceActual)
            {
                case 0:
                    btnOpcion1.Text = "Silencio";
                    btnOpcion2.Text = "Carro";
                    btnOpcion3.Text = "Padre";
                    break;


            }
        }
        private void VerificarAcertijo()
        {
            IResoluble acertijoActual = listaAceLogica[indiceActual];

            if (acertijoActual.Resolver(respuestaUsuario))
            {
                timerJuego.Stop();
                IPuntuacion puntuacionGanada = listaAceLogica[indiceActual];
                Puntuacion += puntuacionGanada.GanarPuntos(TiempoDeJuego, respuestaUsuario);
                TiempoDeJuego = 60;
                indiceActual++;
                empezarAcertijo = false;
                AvanzarDialogo();
            }
            else
            {
                fallos = listaAceLogica[indiceActual].Intentos;
            }
        }
        
        private void btnOpcion1_Click(object sender, EventArgs e)
        {
            respuestaUsuario = btnOpcion1.Text;
            VerificarAcertijo();
        }

        private void btnOpcion2_Click(object sender, EventArgs e)
        {
            respuestaUsuario = btnOpcion2.Text;
            VerificarAcertijo();

        }

        private void btnOpcion3_Click(object sender, EventArgs e)
        {
            respuestaUsuario = btnOpcion3.Text;
            VerificarAcertijo();
        }
    }
}

