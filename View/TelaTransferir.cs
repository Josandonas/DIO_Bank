using System;
namespace DIO_Bank.View{
    public class TelaTransferir{
        public void titulo(){
            Console.WriteLine("*************************************************");
            Console.WriteLine("*                Transferência                  *");
            Console.WriteLine("*************************************************");
        }
        public void NumeroOrigem(){
            Console.WriteLine("*************************************************");
            Console.WriteLine("*        Digite o número da Conta Origem:       *");
            Console.WriteLine("*************************************************");
            Console.WriteLine("*                                               *");
        }
        public void NumeroDestino(){
            Console.WriteLine("*************************************************");
            Console.WriteLine("*        Digite o número da Conta Detino:       *");
            Console.WriteLine("*************************************************");
            Console.WriteLine("*                                               *");
        }
        public void ValorTranferencia(){
            Console.WriteLine("*************************************************");
            Console.WriteLine("*    Digite o valor que deseja transfereir:     *");
            Console.WriteLine("*************************************************");
            Console.WriteLine("*                                               *");
        }
        public void Saida(){
            Console.WriteLine("*                                               *");
            Console.WriteLine("*************************************************");
        }
    }
}