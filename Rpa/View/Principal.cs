using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rpa.View
{
    public partial class Principal : Form
    {
        Bot bot;
        public Principal()
        {
            InitializeComponent();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            int pos;
            if (txt_buscar_palabra.Text.Length > 0 && txt_posicion.Text.Length > 0)
            {
                pos = Int32.Parse(txt_posicion.Text);
                bot = new Bot();
                bot.OpenNewTab(bot.Search(txt_buscar_palabra.Text, pos));
                string lastParagraph = bot.GetLastParagraph();
                txt_ultimo_parrafo.Text = lastParagraph;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Complete los campos requeridos", "Advertencia",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Exclamation,
                  MessageBoxDefaultButton.Button1);
            }
        }
    }
}
