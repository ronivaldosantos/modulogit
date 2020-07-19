using System;
using System.Globalization;

namespace Encapsulamento_01
{
    class Produto
    {
        // padrão nomeclatura atributos privativos: "_" antes do nome começando com letra minuscula

        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }


        // Construtor
        public Produto() {
        }

        //Sobre carga do construtor.
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Utilizando property
        public string Nome {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
