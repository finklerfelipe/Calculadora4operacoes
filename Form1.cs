using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraG2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            calculadora clc = new calculadora();
            clc.numero1 = float.Parse(boxnumero1.Text);
            clc.numero2 = float.Parse(boxnumero2.Text);

            boxresultado.Text = (clc.numero1 / clc.numero2).ToString();
        }

        private void Adicionar_Click(object sender, EventArgs e)
        {
            
            calculadora clc = new calculadora();
            clc.numero1 = float.Parse(boxnumero1.Text);
            clc.numero2 = float.Parse(boxnumero2.Text);

            boxresultado.Text = (clc.numero1 + clc.numero2).ToString();



        }

        private void Subtracao_Click(object sender, EventArgs e)
        {
            calculadora clc = new calculadora();
            clc.numero1 = float.Parse(boxnumero1.Text);
            clc.numero2 = float.Parse(boxnumero2.Text);

            boxresultado.Text = (clc.numero1 - clc.numero2).ToString();
        }

        private void Multiplicacao_Click(object sender, EventArgs e)
        {
            calculadora clc = new calculadora();
            clc.numero1 = float.Parse(boxnumero1.Text);
            clc.numero2 = float.Parse(boxnumero2.Text);

            boxresultado.Text = (clc.numero1 * clc.numero2).ToString();
        }

        private void Boxnumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lblresultado_Click(object sender, EventArgs e)
        {

        }
    }
}
