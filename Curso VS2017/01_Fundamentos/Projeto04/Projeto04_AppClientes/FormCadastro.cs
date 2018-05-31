using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto04_AppClientes.Classes;
using System.IO;

namespace Projeto04_AppClientes
{
    public partial class FormCadastro : Form
    {
        List<string> nomes = new List<string>();

        public FormCadastro()
        {
            InitializeComponent();
        }

        private void incluirClienteButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente;
                string documento = documentoTextBox.Text;
                if (documento.Length == 11)
                {
                    cliente = new ClientePF();
                }
                else if (documento.Length == 14)
                {
                    cliente = new ClientePJ();
                }
                else
                {
                    throw new Exception("Documento inválido");
                }

                cliente.Nome = nomeTextBox.Text;
                cliente.Telefone = telefoneTextBox.Text;
                cliente.Email = emailTextBox.Text;
                cliente.NumeroDocumento = documento;

                clienteComboBox.Items.Add(cliente);
                nomes.Add(cliente.Nome);

                MessageBox.Show("Cliente adicionado com sucesso");
                nomeTextBox.Clear();
                telefoneTextBox.Clear();
                emailTextBox.Clear();
                documentoTextBox.Clear();
                nomeTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message, 
                    "Erro", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }

            
        }

        private void incluirAutomovelButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteComboBox.Items.Count == 0)
                {
                    throw new InvalidOperationException("Não existem clientes disponíveis");
                }

                Automovel auto = new Automovel();
                auto.Marca = marcaTextBox.Text;
                auto.Modelo = modeloTextBox.Text;
                auto.Ano = int.Parse(anoTextBox.Text); //Convert.ToInt32(anoTextBox.Text);

                object cliente = clienteComboBox.SelectedItem;
                if (cliente is ClientePF)
                {
                    /*  Se a variável cliente não referenciar uma instância de ClientePF, 
                     *  a instrução: (ClientePF)cliente lança uma exceção do tipo 
                     *  InvalidCastException */
                    auto.InfoCliente = (ClientePF)cliente;
                }
                else if (cliente is ClientePJ)
                {
                    /*  Se a variável cliente não referenciar uma instância de ClientePJ, 
                     *  a propriedade InfoCliente receberá uma referência nula (null) */
                    auto.InfoCliente = cliente as ClientePJ;
                }

                //((Cliente)cliente).Automoveis = new List<Automovel>();
                ((Cliente)cliente).Automoveis.Add(auto);
                //ou (cliente as Cliente).Automoveis.Add(auto);

                marcaTextBox.Clear();
                modeloTextBox.Clear();
                anoTextBox.Clear();
                
                MessageBox.Show(auto.Mostrar());
            }
            catch (InvalidOperationException ex)
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\no5117\Documents\Curso_VS2017\erro.log", true);
                sw.WriteLine("[" + DateTime.Now + "] - " + ex.Message);
                sw.Close();
                MessageBox.Show("Um arquivo foi gerado com o erro.");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + erro.Message);
            }

        }

        private void listarAutomoveisButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtendo o objeto cliente no comboBox
                Cliente cliente = (Cliente)clienteComboBox.SelectedItem;
                automoveisListBox.Items.Clear();
                if (cliente.Automoveis.Count == 0)
                {
                    automoveisListBox.Items.Add("Nenhum automóvel para este cliente");
                }
                else
                {
                    cliente.Automoveis.Sort();
                    foreach (Automovel item in cliente.Automoveis)
                    {
                        automoveisListBox.Items
                            .Add(item.Marca + " " + item.Modelo);
                    }
                } 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listarClientesButton_Click(object sender, EventArgs e)
        {
            nomes.Sort();
            nomesListBox.Items.Clear();
            foreach (var item in nomes)
            {
                nomesListBox.Items.Add(item);
            }

        }
    }
}
