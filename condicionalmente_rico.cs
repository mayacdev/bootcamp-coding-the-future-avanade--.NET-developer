using System;

class Program
{
    static void Main(string[] args)
    {
		int saldoTotal = int.Parse(Console.ReadLine());
        int valorSaque = int.Parse(Console.ReadLine());
		
		ContaBancaria contaBancaria = new ContaBancaria(saldoTotal,valorSaque);
               
        //TODO: Criar as condições necessárias para impressão da saída, vide tabela de exemplos.
		Console.WriteLine(contaBancaria.RealizarSaque());
    }
}

public class ContaBancaria
{	
  public ContaBancaria(int saldoTotal, int valorSaque)
  {
    SaldoTotal = saldoTotal;
    ValorSaque = valorSaque;
  }
  
  public int SaldoTotal {get; private set;}
  public int ValorSaque {get; private set;}
  
  public string RealizarSaque()
  {
    int calcularSaque = SaldoTotal - ValorSaque;
    return calcularSaque > 0 ? string.Format(Constantes.SAQUE_REALIZADO_COM_SUCESSO,calcularSaque) : Constantes.SALDO_INSUFICIENTE;
  }
}

public static class Constantes
{
  public const string SAQUE_REALIZADO_COM_SUCESSO = "Saque realizado com sucesso. Novo saldo: {0}";
  public const string SALDO_INSUFICIENTE = "Saldo insuficiente. Saque nao realizado!";
}