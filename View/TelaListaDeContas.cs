using System;
namespace DIO_Bank.View{
    public class TelaListaDeContas{
        public void topo(){
            Console.WriteLine("*************************************************");
            Console.WriteLine("*                Lista de Contas                *");
            Console.WriteLine("*************************************************");
        }
        public void calda(){
            Console.WriteLine("*************************************************");
        }
        public void mensagemVazio(){
            Console.WriteLine("*         Infelizmente não há nenhuma conta     *");
        }
    }
}