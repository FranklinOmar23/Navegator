using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegator
{
    public partial class Form1 : Form
    {
        List<string> favoritos = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnDelanten_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(texBuscador.Text);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            favoritos.Add(webBrowser1.Url.ToString());
            actualizarcombox();
        }

        private void actualizarcombox()
        {
            foreach(string direccion in favoritos)
            {
                combfavoritos.Items.Add(direccion);

            }
        }

        private void combfavoritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(combfavoritos.SelectedItem.ToString());
        }
    }
}
