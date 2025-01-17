﻿using System;
namespace Calculadora
{
    public class Calculadora
    {
        public Operacoes calcular(Operacoes operacao)
        {
            switch (operacao.operador)
            {
                case '+': operacao.resultado = soma(operacao); break;
                case '-': operacao.resultado = subtracao(operacao); break;
                case '*': operacao.resultado = multiplicacao(operacao); break;
                case '/': operacao.resultado = divisao(operacao); break;
                default: operacao.resultado = 0; break;
            }
            return operacao;
        }

        public decimal soma(Operacoes operacao)
        {
            return (decimal)operacao.valorA + operacao.valorB;
        }

        public decimal subtracao(Operacoes operacao)
        {
            return (decimal)operacao.valorA - operacao.valorB;
        }

        public decimal multiplicacao(Operacoes operacao)
        {
            return (decimal)operacao.valorA * operacao.valorB;
        }

        public decimal divisao(Operacoes operacao)
        {
                return (decimal)operacao.valorA / operacao.valorB;
        }
    }
}

