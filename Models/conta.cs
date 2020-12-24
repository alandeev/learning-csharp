using System;

namespace OOP {
  class Account {
    public string name { get; set; }
    private float saldo { get; set; }
    public string Numero { get; set; }
    public string DataDeValidade { get; set; }
    public Client Client { get; set; }

    public Account(Client client){
      this.Client = client;
    }

    public float Depositar(float value){
      this.saldo += value;
      return this.saldo;
    }

    public void Pagar(float value){
      if(this.saldo < value){
        throw new Exception("Do you do not have Money enought");
      }

      this.saldo -= value;
    }
    public float ConsultarSaldo(){
      return this.saldo;
    }
  }
}






