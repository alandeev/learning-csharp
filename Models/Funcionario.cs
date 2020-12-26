using System;

namespace OOP {
  public abstract class Funcionario {
    public string Nome { get; protected set; }
    public double Salario { get; protected set; }

    //constructor
    protected Funcionario(){
      this.trabalhar();
    }

    public void setName(string name){
      this.Nome = name;
    }

    public void setSalario(double salario){
      this.Salario = salario;
    }
    public abstract void trabalhar();
  }
}
