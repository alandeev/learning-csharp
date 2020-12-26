namespace OOP
{
  public interface IAccount {
    public string name { get; set; }
    public float saldo { get; set; }
    public string Numero { get; set; }
    public string DataDeValidade { get; set; }
    public void Depositar(float valor);
    public bool Pagar(float valor);

    public abstract float taxaDep { get; set; }
    public abstract float ConsultarSaldo();
  }    
}