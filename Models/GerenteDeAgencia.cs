using System;

namespace OOP {
  public class GerenteDeAgencia: Gerente {
    public override void trabalhar()
    {
      this.Salario += 2000;
    }
  }
}
