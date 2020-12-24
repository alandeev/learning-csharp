using System;

namespace OOP {
  public abstract class Funcionario {
    protected Funcionario(){
      this.trabalhar();
    }
    public string Nome { get; set; }
    public double Salario { get; set; }

    public abstract void trabalhar();
  }
}
