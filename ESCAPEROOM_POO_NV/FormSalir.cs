using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESCAPEROOM_POO_NV
{
    public partial class FormSalir : Form
    {
        public FormSalir()
        {
            this.KeyDown += (s, e) => {
                if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left || e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                {
                    // Si el foco está en el botón SI, pásalo al NO, y viceversa
                    if (btnSiSalir.Focused) btnNoSalir.Focus();
                    else btnSiSalir.Focus();
                }

                if (e.KeyCode == Keys.Enter)
                {
                    // Al presionar Enter, el botón enfocado ejecutará su DialogResult automáticamente
                }
            };

            InitializeComponent();
        }

        private void btnSiSalir_Enter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BringToFront();
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.White;
        }

        private void btnSiSalir_Leave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.FlatAppearance.BorderSize = 0;
        }

        private void btnNoSalir_Enter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BringToFront();
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = Color.White;
        }

        private void btnNoSalir_Leave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.FlatAppearance.BorderSize = 0;
        }

        //

        private void btnSiSalir_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Focus();
        }
        private void btnNoSalir_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Focus();
        }
    }
    
}
