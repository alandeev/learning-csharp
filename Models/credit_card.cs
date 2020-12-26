using System;

// interface ICard {
//   public string Number { get; set; }
//   public string DataDeValidade { get; set; }
// }

namespace OOP {
  class CreditCard: Account {
    public bool pay_now = false;
    public override float taxaDep { get; set; }

    public CreditCard(){
      this.taxaDep = 4f;
    }

    public override bool Pagar(float value){
      bool deuCertoPagamento = base.Pagar(value);
      if(!deuCertoPagamento){
        return false;
      }

      this.saldo -= 6;
      return true;
    }
    public override float ConsultarSaldo(){
      return this.saldo-taxaDep;
    }
  }
}
