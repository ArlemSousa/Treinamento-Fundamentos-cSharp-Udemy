using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao
{
    internal class ContaBancaria
    {

        //criadas as propriedades privadas
        private int _numeroConta;
        private string? _titular;
        private double _saldo;

        //encapsuladas as propriedades
        public int NumeroConta { get => _numeroConta; set => _numeroConta = value; }
        public string? Titular { get => _titular; set => _titular = value; }
        public double Saldo { get => _saldo; set => _saldo = value; }

        //construtor padrão
        public ContaBancaria() { }

        //construtor com todos os argumentos
        public ContaBancaria(int numeroConta, string? titular, double depositoInicial)
        {
            _numeroConta = numeroConta;
            _titular = titular;
            Deposito(depositoInicial);
        }

        //construtor sem o argumento saldo
        public ContaBancaria(int numeroConta, string? titular)
        {
            _numeroConta = numeroConta;
            _titular = titular;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        } 

        
        public override string ToString()
        {
            return "Conta: " + NumeroConta +
                   "\nTitular: " + Titular +
                   "\nSaldo: " + Saldo.ToString();
            //acesso as propriedades encapsuladas
        }
    }
}
