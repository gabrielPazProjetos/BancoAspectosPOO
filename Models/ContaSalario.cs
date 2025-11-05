namespace BancoAspectos.Models;

public class ContaSalario : Conta
{
    public ContaSalario(string tipoCliente, DateTime dataAbertura, double saldoInicial)
        : base("Salário", tipoCliente, dataAbertura, saldoInicial) { }

    public override double CalcularValorTarifaManutencao() => 0.0;
}
