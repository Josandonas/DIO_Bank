using System;
namespace DIO_Bank.View{
    public class TelaDepositar{        
        public void Entrada(){
            Console.WriteLine("*************************************************");
            Console.WriteLine("*                    Deposito                   *");
            Console.WriteLine("*************************************************");
        }
        public void NumeroOrigem(){
            Console.WriteLine("*************************************************");
            Console.WriteLine("*        Digite o número da Conta Origem:       *");
            Console.WriteLine("*************************************************");
            Console.WriteLine("*                                               *");
        }
        public void NumeroConta(){
            Console.WriteLine("*************************************************");
            Console.WriteLine("*        Digite o número da Conta Detino:       *");
            Console.WriteLine("*************************************************");
            Console.WriteLine("*                                               *");
        }
        public void ValorDeposito(){
            Console.WriteLine("*************************************************");
            Console.WriteLine("*         Digite o o valor do deposito:         *");
            Console.WriteLine("*************************************************");
            Console.WriteLine("*                                               *");
        }
        public void Saida(){
            Console.WriteLine("*                                               *");
            Console.WriteLine("*************************************************");
        }
    }
}