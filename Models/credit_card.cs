using System;

// interface ICard {
//   public string Number { get; set; }
//   public string DataDeValidade { get; set; }
// }

namespace OOP {
  class CreditCard: Account {
    public bool pay_now = false;
    public CreditCard(Client client): base(client){}
  }
}
