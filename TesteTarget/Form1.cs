using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TesteTarget
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var response = "Informe um valor";

            if (textBox1.TextLength > 0)
                response = Fibonacci.CalcFibonacci(int.Parse(textBox1.Text));

            MessageBox.Show(response);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var response = CalcularFaturamento.Faturamento("../../../dados.json").ToString();
            MessageBox.Show(response);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var fatDistrib = new List<FatDistribuidora>() { new FatDistribuidora { UF = "SP", Valor = 67836.43M },
                                                            new FatDistribuidora { UF = "RJ", Valor = 36678.66M },
                                                            new FatDistribuidora { UF = "MG", Valor = 29229.88M },
                                                            new FatDistribuidora { UF = "ES", Valor = 27165.48M },
                                                            new FatDistribuidora { UF = "Outros", Valor = 19849.53M }
            };

            var response = CalcularPercentual.Percentual(fatDistrib);

            MessageBox.Show(response.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var response = InverterTexto.Inverter(txtInvert.Text);
            MessageBox.Show(response);
        }        
    }
}

