using System;
namespace DIO_Bank.View{
    public class TelaSacar{
        public void Entrada(){
            Console.WriteLine("*************************************************");
            Console.WriteLine("*                      Saque                    *");
            Console.WriteLine("*************************************************");
        }
        public void NumeroConta(){
            Console.WriteLine("*************************************************");
            Console.WriteLine("*            Digite o número da Conta:          *");
            Console.WriteLine("*************************************************");
            Console.WriteLine("*                                               *");
        }
        public void ValorSaque(){
            Console.WriteLine("*************************************************");
            Console.WriteLine("*           Digite o o valor do saque:          *");
            Console.WriteLine("*************************************************");
            Console.WriteLine("*                                               *");
        }
        public void Saida(){
            Console.WriteLine("*                                               *");
            Console.WriteLine("*************************************************");
        }
    }
}