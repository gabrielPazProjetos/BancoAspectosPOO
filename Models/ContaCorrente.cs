namespace BancoAspectos.Models;

public class ContaCorrente : Conta
{
    public ContaCorrente(string tipoCliente, DateTime dataAbertura, double saldoInicial)
        : base("Corrente", tipoCliente, dataAbertura, saldoInicial) { }

    public override double CalcularValorTarifaManutencao() => 12.50;
}
