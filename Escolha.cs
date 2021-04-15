using DIO_Bank.Controller;
using DIO_Bank.View;
using System;

namespace DIO_Bank{
    public class Escolha{
        public void Entrada(){
            var menu= new TelaMenuEntrada();
            String opcaoUsuario= menu.menuInicial();
            var operacoes= new OperacoesConta();
            while(opcaoUsuario.ToUpper() != "X"){
                switch(opcaoUsuario){
                    case "1":
                        operacoes.ListaContas();
                        break;
                    case "2":
                        operacoes.InserirContas();
                        break;
                    case "3":
                        operacoes.Transferir();
                        break;
                    case "4":
                        operacoes.Sacar();
                        break;
                    case "5":
                        operacoes.Depositar();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario= menu.menuInicial();
            }
        }
    }
}