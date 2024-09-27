using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertidor_Hexa
{
    public partial class Form1 : Form
    {
        String texto;
        float numeroflotante;
        double numerodouble;

        public Form1()
        {
            InitializeComponent();
        }

        private void decibox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hexabox_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonconv_Click(object sender, EventArgs e)
        {
            
            texto= decibox.Text;
            if (botondd.Checked)
            {
                numeroflotante = float.Parse(texto);
                byte[] numerohexa2 = BitConverter.GetBytes(numeroflotante);
                label1.Text = "Número Convertido (DD)";
                hexabox.Text = BitConverter.ToString(numerohexa2);
            }

            else if (botondq.Checked)
            {
                numerodouble = Convert.ToDouble(texto);
                byte[] numerohexa1 = BitConverter.GetBytes(numerodouble);
                label1.Text = "Número Convertido (DQ)";
                hexabox.Text = BitConverter.ToString(numerohexa1);
            }

        }
    }
}
