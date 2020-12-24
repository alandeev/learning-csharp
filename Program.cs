using System;

namespace OOP {
  class Program {
    static void Main(string[] args) {
      AnalistaDeTI analistaDeTI = new AnalistaDeTI();
      Gerente gerente = new Gerente();
      GerenteDeAgencia gerenteDeAgencia = new GerenteDeAgencia();
      GerenteDeTI gerenteDeTI = new GerenteDeTI();

      Console.WriteLine("AnalistaDeTI: {0}", analistaDeTI.Salario);
      Console.WriteLine("Gerente: {0}", gerente.Salario);
      Console.WriteLine("GerenteDeAgencia: {0}", gerenteDeAgencia.Salario);
      Console.WriteLine("gerenteDeTI: {0}", gerenteDeTI.Salario);


      // Client client_1 = new Client();
      // client_1.name = "João";
      // client_1.lastname = "Pedro";
      // client_1.age = 18;

      // CreditCard creditCard_1 = new CreditCard(client_1);
      // creditCard_1.Numero = "5341.1231.4213.1122";
      // creditCard_1.DataDeValidade = "12/11/2023";
      // creditCard_1.Depositar(12.2f);
      
      // try{
      //   creditCard_1.Pagar(13);
      // }catch(Exception error){
      //   Console.WriteLine("Error: {0}", error.Message);
      // }

      // Console.WriteLine("O nome do cliente é " + client_1.name);
      // Console.WriteLine("O número do cartão é " + creditCard_1.Numero);
      // Console.WriteLine("A data de validade é " + creditCard_1.DataDeValidade);
      // Console.WriteLine("O Saldo atual é " + creditCard_1.ConsultarSaldo()); 
      // Console.WriteLine("Tipo de Conta: {0}", (creditCard_1.pay_now ? "Debito" : "Credito"));

      // Client client_2 = new Client();
      // client_2.name = "Antonio";
      // client_2.lastname = "Barbosa";
      // client_2.age = 24;

      // DebitCard debitCard = new DebitCard(client_2);
      // debitCard.Numero = "4321.4652.1231.2222";
      // debitCard.DataDeValidade = "12/11/2028";
      // debitCard.Depositar(325.2f);

      // Console.WriteLine("");
      // Console.WriteLine(""); 
      // Console.WriteLine("");

      // Console.WriteLine("O nome do cliente é " + client_2.name);
      // Console.WriteLine("O número do cartão é " + debitCard.Numero);
      // Console.WriteLine("A data de validade é " + debitCard.DataDeValidade);
      // Console.WriteLine("O Saldo atual é " + debitCard.ConsultarSaldo()); 
      // Console.WriteLine("Tipo do cartão: {0}", (debitCard.pay_now ? "Debito" : "Credito"));

      // debitCard.Pagar(200);

      // Console.WriteLine("Novo saldo da conta é: " + debitCard.ConsultarSaldo()); 
      
    }
  }
}
