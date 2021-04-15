using System;
using System.Collections.Generic;
using DIO_Bank.View;
namespace DIO_Bank.Controller{
    public class OperacoesConta{
        static List<Contas> listaContas= new List<Contas>();
        public void InserirContas(){
            var partes= new TelaContaNova();
            partes.titulo();
            bool saida=false;
            String leitura;
            partes.pergunta1();
            while(saida == false){
                leitura = Console.ReadLine();
                if(leitura != "1" && leitura != "2"){
                    Console.WriteLine("Opcao inexistente, por gentileza tecle 1 ou 2");
                    leitura="";
                    saida=false;
                }else{
                    int entradaTipoConta = int.Parse(leitura);
                    partes.pergunta2();
                    String entradaNome = Console.ReadLine();
                    partes.pergunta3();
                    double entradaSaldo = double.Parse(Console.ReadLine());
                    partes.pergunta4();
                    double entradaCredito= double.Parse(Console.ReadLine());
                    partes.fimPergunta();
                    Contas novaConta= new Contas(
                    tipoConta: (TipoConta)entradaTipoConta,
                    saldo: entradaSaldo, 
                    credito: entradaCredito, 
                    nome:entradaNome);
                    listaContas.Add(novaConta);
                    saida=true;
                }
            }
            
        }
        public void ListaContas(){
            var blocos= new TelaListaDeContas();
            blocos.topo();
            if(listaContas.Count ==0){ 
                blocos.mensagemVazio();
                blocos.calda();
                System.Threading.Thread.Sleep(1000);
            }
            for(int i=0; i<listaContas.Count; i++){
                Contas contas=listaContas[i];
                Console.Write("# {0}",i);
                Console.WriteLine(contas);                
                blocos.calda();
                System.Threading.Thread.Sleep(1000);
            }
        }
        public void Sacar(){
            var blocos = new TelaSacar();
            blocos.Entrada();
            blocos.NumeroConta();
            int indiceConta = int.Parse(Console.ReadLine());
            blocos.ValorSaque();
            double valorSaque = double.Parse(Console.ReadLine());
            blocos.Saida();
            listaContas[indiceConta].Sacar(valorSaque);
        }
        public void Depositar(){
            var depositar = new TelaDepositar();
            depositar.Entrada();
            depositar.NumeroConta();
            int indiceConta = int.Parse(Console.ReadLine());
            depositar.ValorDeposito();
            double valorDeposito = double.Parse(Console.ReadLine());
            depositar.Saida();
            listaContas[indiceConta].Depositar(valorDeposito);
        }
        public void Transferir(){
            var transferir = new TelaTransferir();
            transferir.titulo();
            transferir.NumeroOrigem();
            int indiceContaOrigem= int.Parse(Console.ReadLine());
            transferir.NumeroDestino();
            int indiceContaDestino= int.Parse(Console.ReadLine());
            transferir.ValorTranferencia();
            double valorTransferencia= double.Parse(Console.ReadLine());
            
            listaContas[indiceContaOrigem].Transferir(valorTransferencia,listaContas
            [indiceContaDestino]);
        }
    }
}