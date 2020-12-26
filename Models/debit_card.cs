using System;

namespace OOP {
  class DebitCard: Account {
    public bool pay_now = true;
    public override float taxaDep { get; set; }
    public DebitCard(){
      this.taxaDep = 0;
    }
    public override float ConsultarSaldo(){
      return this.saldo-taxaDep;
    }
  }
}
