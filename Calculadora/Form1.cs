using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                Console.WriteLine("INSIRA DADOS");
            }
            else
            {
                double n1, n2, resultado;

                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);

                resultado = n1 + n2;

                MessageBox.Show(n1 + " + " + n2 + " = " + resultado);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                Console.WriteLine("INSIRA DADOS");
            }
            else
            {
                double n1, n2, resultado;

                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);

                resultado = n1 - n2;

                MessageBox.Show(n1 + " - " + n2 + " = " + resultado);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                Console.WriteLine("INSIRA DADOS");
            }
            else
            {
                double n1, n2, resultado;

                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);

                resultado = n1 * n2;


                MessageBox.Show(n1 + " x " + n2 + " = " + resultado);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                Console.WriteLine("INSIRA DADOS");
            }

            else
            {
                double n1, n2, resultado;

                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);

                resultado = n1 / n2;

                MessageBox.Show(n1 + " / " + n2 + " = " + resultado);
            }
        }
    }
}
