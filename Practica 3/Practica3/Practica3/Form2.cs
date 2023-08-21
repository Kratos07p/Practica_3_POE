using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Form2 : Form
    {


        public Form2()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(tbNum1.Text);
            double num2 = Convert.ToDouble(tbNum2.Text);
            Calculadora objeto1 = new Calculadora(num1, num2);
            MessageBox.Show("Suma: " + objeto1.suma().ToString());
            MessageBox.Show("Resta: " + objeto1.resta().ToString());
            MessageBox.Show("Multiplicación: " + objeto1.multiplicacion().ToString());
            MessageBox.Show("Division: " + objeto1.division().ToString());
        }

        private void tbNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNum2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
