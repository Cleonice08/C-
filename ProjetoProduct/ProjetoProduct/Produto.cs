﻿using System.Globalization;

namespace ProjetoProduct
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void Adicionarprodutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void Removerprodutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quantidade + " unidades, Total: $" +
                ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
