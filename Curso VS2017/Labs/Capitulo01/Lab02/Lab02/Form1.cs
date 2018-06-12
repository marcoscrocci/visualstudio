using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class lab02Form : Form
    {
        public lab02Form()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            //Definir as variáveis e inicializá-las
            decimal valorCompra = 0;
            decimal valorPago = 0;
            decimal resto = 0;

            //Converter os valores de tela para os tipos
            //correspondentes das variáveis
            valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);
            valorPago = Convert.ToDecimal(valorPagoTextBox.Text);

            //Calcular a diferença a ser devolvida
            //troco, que foi chamado de resto
            resto = valorPago - valorCompra;

            //Definir e atribuir o cálculo de moedas à variável
            int moedas1 = (int)(resto / 1);
            resto = resto % 1;
            moedas1Label.Text = moedas1.ToString();

            //Definir e atribuir o cálculo de moedas à variável
            int moedas050 = (int)(resto / 0.50m);
            resto = resto % 0.50m;
            moedas050Label.Text = moedas050.ToString();

            //Definir e atribuir o cálculo de moedas à variável
            int moedas025 = (int)(resto / 0.25m);
            resto = resto % 0.25m;
            moedas025Label.Text = moedas025.ToString();

            //Definir e atribuir o cálculo de moedas à variável
            int moedas010 = (int)(resto / 0.10m);
            resto = resto % 0.10m;
            moedas010Label.Text = moedas010.ToString();

            //Definir e atribuir o cálculo de moedas à variável
            int moedas005 = (int)(resto / 0.05m);
            resto = resto % 0.05m;
            moedas005Label.Text = moedas005.ToString();

            //Definir e atribuir o cálculo de moedas à variável
            int moedas001 = (int)(resto / 0.01m);
            resto = resto % 0.01m;
            moedas001Label.Text = moedas001.ToString();

            //Somar os resultados para verificação e exibir em tela
            //em formato monetário com duas casas pós-vírgula
            trocoLabel.Text = (moedas1 +
            moedas050 * 0.5 +
            moedas025 * 0.25 +
            moedas010 * 0.1 +
            moedas005 * 0.05 +
            moedas001 * 0.01).ToString("C2");

        }

    }
}
