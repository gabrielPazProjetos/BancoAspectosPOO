namespace BancoAspectos.Models;

public class ContaPoupanca : Conta
{
    public ContaPoupanca(string tipoCliente, DateTime dataAbertura, double saldoInicial)
        : base("Poupança", tipoCliente, dataAbertura, saldoInicial) { }

    public override double CalcularValorTarifaManutencao() => 0.0;
}
