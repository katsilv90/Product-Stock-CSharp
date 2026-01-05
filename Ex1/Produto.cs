using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1
{
    internal class Produto
    {
        //Atributos
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Stock { get; set; }

        //Construtores
        //Construtor padrão
        public Produto()
        {
            Stock = 0;
        }
        //Construtor com parâmetros
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Stock = quantidade;
        }
        //Métodos
        //Adicionar produtos ao stock
        public void AdicionarProdutos(int quantidade)
        {
            Stock += quantidade;
        }
        //Remover produtos do stock
        public void RemoverProdutos(int quantidade)
        {
            Stock -= quantidade;
        }
        //Consultar valor total do stock
        public double ConsultarStock()
        {
            return Preco * Stock;
        }
        //Sobrescrever método ToString
        public override string ToString()
        {
            return $"Produto: {Nome}, Preço(Un): {Preco:F2}€, Unidades: {Stock}, Valor Total: {ConsultarStock():F2}€";
        }
    }
}
