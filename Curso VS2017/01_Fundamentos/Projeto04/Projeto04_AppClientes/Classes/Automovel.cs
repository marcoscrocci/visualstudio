using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04_AppClientes.Classes
{
    public class Automovel: IComparable<Automovel>
    {
        #region Propriedades

        private string _marca;

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        private string _modelo;

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        private int _ano;

        public int Ano
        {
            get { return _ano; }
            set
            {
                if (value < 1929)
                {
                    throw new FormatException("O valor do campo \"Ano\" deve ser maior 1929");
                }
                _ano = value;
            }
        }

        private Cliente cliente;

        public Cliente InfoCliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        #endregion

        #region Métodos

        public string Mostrar()
        {
            /*string resultado =
                "Marca: " + this.Marca +
                "\nModelo: " + this.Modelo +
                "\nAno: " + this.Ano;*/
            string resultado = string
                .Format("Marca: {0}{1}Modelo: {2}{1}Ano: {3}{1}Proprietário: {4}",
                    this.Marca,             // {0} 
                    Environment.NewLine,    // {1} 
                    this.Modelo,            // {2} 
                    this.Ano,               // {3} 
                    this.InfoCliente);      // {4}

            return resultado;
        }

        public int CompareTo(Automovel other)
        {
            if (this.Marca.ToUpper().CompareTo(other.Marca.ToUpper()) == 0)
            {
                return this.Modelo.ToUpper().CompareTo(other.Modelo.ToUpper());
            }
            return this.Marca.ToUpper().CompareTo(other.Marca.ToUpper());
        }

        #endregion

    }
}
