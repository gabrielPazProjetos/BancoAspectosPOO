namespace BancoAspectos.Models;

public abstract class Conta
{
    public string TipoConta { get; set; }
    public string TipoCliente { get; set; }
    public DateTime DataAbertura { get; set; }
    public double Saldo { get; protected set; }

    protected Conta(string tipoConta, string tipoCliente, DateTime dataAbertura, double saldoInicial)
    {
        TipoConta = tipoConta;
        TipoCliente = tipoCliente;
        DataAbertura = dataAbertura;
        Saldo = saldoInicial;
    }

    public virtual void Depositar(double valor)
    {
        Saldo += valor;
        Console.WriteLine($"[INFO] Depósito de R${valor:F2} realizado.");
    }

    public virtual void Sacar(double valor)
    {
        Saldo -= valor;
        Console.WriteLine($"[INFO] Saque de R${valor:F2} realizado.");
    }

    public abstract double CalcularValorTarifaManutencao();
}
