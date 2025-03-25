using System;
using System.Collections.Generic;
using System.Text;

namespace ControleComissao
{
    //classe de manipulação dos objetos
    class Principal
    {
        static void Main(string[] args)
        {
            //método construtor
            Vendedor vendedor1 = new Vendedor();

            //inserindo dados no objeto
            Console.WriteLine("Digite seu nome: ");
            vendedor1.setNome(Console.ReadLine());

            Console.WriteLine("Digite seu salário base: ");
            vendedor1.setSalarioBase(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Digite o valor vendido: ");
            double valorVendido = Convert.ToDouble(Console.ReadLine());

            //exibir os dados
            Console.WriteLine("Seu nome é: " + vendedor1.getNome());
            Console.WriteLine("Seu salário base é: " + vendedor1.getSalarioBase());

            //chamando (invocando) o método específico da classe
            Console.WriteLine("Sua comissão é de: R$ " + vendedor1.calcularComissao(valorVendido));

            //calculando o total
            Console.WriteLine("Seu salário total é de: R$ " + (vendedor1.getSalarioBase() + vendedor1.calcularComissao(valorVendido)));   
        }
    }
}
