using System;

namespace OOP {
  public abstract class Account: IAccount {
    public string name { get; set; }
    public float saldo { get; set; }
    public string Numero { get; set; }
    public string DataDeValidade { get; set; }

    public abstract float taxaDep { get; set; }

    public void Depositar(float value){
      this.saldo += value;
    }

    public virtual bool Pagar(float value){
      if(this.saldo < value){
        return false;
      }

      this.saldo -= value;
      return true;
    }
    public abstract float ConsultarSaldo();
  }
}






