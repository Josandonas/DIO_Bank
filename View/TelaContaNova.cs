using System;
namespace DIO_Bank.View{
    public class TelaContaNova{
        public void titulo(){
            Console.WriteLine("*************************************************");
            Console.WriteLine("*             Cadastrando Nova Conta            *");
            Console.WriteLine("*************************************************");
        }
        public void pergunta1(){
            Console.WriteLine("*                                                *");
            Console.WriteLine("* Digite 1 para Conta Física ou 2 para Jurídica: *");
        }
        public void pergunta2(){
            Console.WriteLine("*                                                *");
            Console.WriteLine("* Digite o Nome do Cliente:                      *");
        }
        public void pergunta3(){
            Console.WriteLine("*                                                *");
            Console.WriteLine("* Digite o Saldo Inicial:                        *");
        }
        public void pergunta4(){
            Console.WriteLine("*                                                *");
            Console.WriteLine("* Digite o Crédito:                              *");
        }
        public void fimPergunta(){
            Console.WriteLine("**************************************************");
        }
    }
}