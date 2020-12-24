using System;

namespace OOP {
  class DebitCard: Account {
    public bool pay_now = true;
    public DebitCard(Client client): base(client){}
  }
}
