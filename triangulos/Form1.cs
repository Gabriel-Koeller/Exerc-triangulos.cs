using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lado1_TextChanged(object sender, EventArgs e)
        {


       
        }

        private void verificar_Click(object sender, EventArgs e)
        {

            double l1;
            double l2;
            double l3;

            l1 = double.Parse(lado1.Text);
            l2 = double.Parse(lado2.Text);
            l3 = double.Parse(lado3.Text);

           


            if ((l1 + l2) > l3 || (l1 + l3) > l2 || (l3+ l2) > l1)
            {
                if (l1 == l2 && l1 == l3 )
                {
                    resposta.Text = "Triângulo Equilátero – Três lados iguais. ";
                } else if (l1 == l2 || l1 == l3 || l3 == l2) 
                {
                    resposta.Text = "Triângulo Isósceles – Dois lados iguais. ";
                }else
                {
                    resposta.Text = "Triângulo escaleno – Lados diferentes. ";
                }

                MessageBox.Show(" é um triângulo!");

            }
            else
            {
                MessageBox.Show("Não é um triângulo!");

            }

        }
           

            // MessageBox.Show("lados: " + l1 + l2 + l3);

        }
}

