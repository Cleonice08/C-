﻿using ProjetoProduct;
using System;
using System.Globalization;

Produto p = new Produto();

Console.WriteLine("Entre com os dados do produto: ");
Console.Write("Nome: ");
p.Nome = Console.ReadLine();
Console.Write("Preço: ");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");
p.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Dados do produto: " + p);

Console.WriteLine();
Console.Write("Digite o número de produtos a ser adicionados ao estoque: ");
int qte = int.Parse(Console.ReadLine());
p.Adicionarprodutos(qte);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);

Console.WriteLine();
Console.Write("Digite o número de produtos a ser removidos ao estoque: ");
qte = int.Parse(Console.ReadLine());
p.Removerprodutos(qte);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);


