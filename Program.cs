using DIO_Bank.View;

namespace DIO_Bank{
    class Program{
        static void Main(string[] args){
           var BancoAberto= new Escolha();
           BancoAberto.Entrada();
           var BancoFechado= new TelaObrigado();
           BancoFechado.obrigado();
        }
    }
}
