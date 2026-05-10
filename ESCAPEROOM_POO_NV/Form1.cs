using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ESCAPEROOM_POO_NV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pnlDialogo.MouseClick += (s, e) => GestionarClickDialogo();
            lblDialogo.MouseClick += (s, e) => GestionarClickDialogo();
            pxbOsaka.MouseClick += (s, e) => GestionarClickDialogo();
        }

        private Queue<DialogosConImagen> secuenciaDialogos = new Queue<DialogosConImagen>();
        bool interruptor = true;

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

                MessageBox.Show("holi");
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

        private void CargarEscena()
        {
            secuenciaDialogos.Clear();
            secuenciaDialogos.Enqueue(new DialogosConImagen("....", Properties.Resources.oSAKASMILE));
            secuenciaDialogos.Enqueue(new DialogosConImagen("Holaaa!!", Properties.Resources.OSAKATALK));
            secuenciaDialogos.Enqueue(new DialogosConImagen("Alfin llega alguien, que emocion!!", Properties.Resources.OSAKATALK));
            secuenciaDialogos.Enqueue(new DialogosConImagen("...", Properties.Resources.oSAKASMILE));
        }
        private void AvanzarDialogo()
        {
            if (secuenciaDialogos.Count > 0)
            {
                if (secuenciaDialogos.Count > 0)
                {
                    DialogosConImagen faseActual = secuenciaDialogos.Dequeue();
                    if (faseActual.Imagen != null) pxbOsaka.Image = faseActual.Imagen;

                    IniciarEfectoTexto(faseActual.Texto);
                }
                else
                {
                    pnlDialogo.Visible = false;
                }
            }
            else
            {
                pnlDialogo.Visible = false;
            }
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

            CargarEscena();

            pnlDialogo.Visible = true;
            lblDialogo.Visible = true;
            lblDialogo.Enabled = true;

            this.Focus();

            AvanzarDialogo();
        }

        private void pnlDialogo_Paint(object sender, PaintEventArgs e)
        {
            // Usamos el color Lime para mantener la estética que ya traes
            using (Pen penBlanco = new Pen(Color.White, 3))
            {
                // Dibujamos el rectángulo principal
                e.Graphics.DrawRectangle(penBlanco, 10, 10, pnlDialogo.Width - 20, pnlDialogo.Height - 20);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}
