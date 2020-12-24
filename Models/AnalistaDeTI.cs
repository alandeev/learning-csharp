using System;

namespace OOP {
  public class AnalistaDeTI: Funcionario {
    public override void trabalhar()
    {
      this.Salario += 800;
      Console.Write("Trabalho: Analista de Sistema...");
    }
  }
}
