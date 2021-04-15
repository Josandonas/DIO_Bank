using System;
namespace DIO_Bank.View{
    public class TelaMenuEntrada{
        public String menuInicial(){
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("  Bank Dio a seu Dispor!!!  ");
            Console.WriteLine(" Informe a opção que deseja ");
            Console.WriteLine("****************************");
            Console.WriteLine("*    1-Listar Contas       *");
            Console.WriteLine("*    2-Inserir Nova Conta  *");
            Console.WriteLine("*    3-Transferir          *");
            Console.WriteLine("*    4-Sacar               *");
            Console.WriteLine("*    5-Depositar           *");
            Console.WriteLine("*    X-Sair                *");
            Console.WriteLine("****************************");
            String opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}