using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_01
{
    public partial class lab01Form : Form
    {
        public lab01Form()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            // declarar e inicializar as variáveis
            int numero = 0;
            int quadrado = 0;

            // atribuir o valor de entrada (tela) na variável numero
            numero = Convert.ToInt32(valorTextBox.Text);

            // calcular o quadrado do valor
            quadrado = numero * numero;

            // exibir o resultado na tela
            resultadoLabel.Text =
                "Quadrado de " + numero.ToString() +
                " é: " + quadrado.ToString("N0");

            // reposicionar o foco
            valorTextBox.Focus();

            // selecionar o conteúdo
            valorTextBox.SelectAll();
        }
    }
}
