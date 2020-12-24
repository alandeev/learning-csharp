using System;

namespace OOP {
  public class GerenteDeTI: Gerente {
    public override void trabalhar(){
      this.Salario += 1600;
    }
  }
}
