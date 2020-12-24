using System;

namespace OOP {
  public class Gerente: Funcionario {
    public override void trabalhar()
    {
      this.Salario += 1000;
      Console.Write("Trabalho: Gerenciando...");
    }
  }
}
