namespace BancoAspectos.Models;

public class ContaInvestimento : Conta
{
    public ContaInvestimento(string tipoCliente, DateTime dataAbertura, double saldoInicial)
        : base("Investimento", tipoCliente, dataAbertura, saldoInicial) { }

    public override double CalcularValorTarifaManutencao() => 25.0;
}
