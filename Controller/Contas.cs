using System;
namespace DIO_Bank.Controller{
    public class Contas{
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }
        public Contas(TipoConta tipoConta, double saldo, double credito, string nome){
            
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }
        public bool Sacar(double valorSaque){
            // Validação de saldo suficiente para sacar
            if(this.Saldo - valorSaque < (this.Credito *-1)){
                Console.WriteLine("Saldo Insuficiente");
                return false;
            }
            this.Saldo -= valorSaque;
            Console.WriteLine("Saldo atual da conta de {0} é {1}",this.Nome,this.Saldo);
            return true;
        }
        public void Depositar(double ValorDeposito){
            this.Saldo +=ValorDeposito;
            Console.WriteLine("Saldo atual da conta de {0} é {1}",this.Nome,this.Saldo);
        }
        public void Transferir(double valorTransferencia, Contas contaDestino){
            if(this.Sacar(valorTransferencia)){
                contaDestino.Depositar(valorTransferencia);

            }
        }
        public override string ToString(){
            String retorno = "";
            retorno+="Tipo de Conta: " + this.TipoConta +" | ";
            retorno+="Nome: " + this.Nome +" | ";
            retorno+="Saldo: " + this.Saldo +" | ";
            retorno+="Crédito: " + this.Credito;
            return retorno;

        }
    }
}