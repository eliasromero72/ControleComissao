using System;

namespace ControleComissao
{
    //classe de modelagem do objeto
    class Vendedor
    {
        //atributos
        private string nome;
        private double salarioBase;

        //getter's e setter's
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return nome;
        }
        public void setSalarioBase(double salarioBase)
        {
            this.salarioBase = salarioBase;
        }
        public double getSalarioBase()
        {
            return salarioBase;
        }
        //método específico da classe
        public double calcularComissao(double valorVendido)
        {
            return valorVendido * 0.03;
        }
        //método NÃO específico da classe (exemplo sem retorno)
        public void calculaComissao2(double valorVendido)
        {
            double comissao = valorVendido * 0.03;
        }
    }
}
