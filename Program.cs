using BancoAspectos.Models;
using BancoAspectos.Aspects;

[assembly: AspectInjector.Broker.Inject(typeof(VerificaSaldoAspect))]

var contas = new List<Conta>
{
    new ContaCorrente("Pessoa Física", DateTime.Now, 100.0),
    new ContaSalario("Pessoa Jurídica", DateTime.Now, 50.0),
    new ContaPoupanca("Pessoa Física", DateTime.Now, 200.0),
    new ContaInvestimento("Pessoa Jurídica", DateTime.Now, 500.0)
};

foreach (var conta in contas)
{
    Console.WriteLine($"\n--- {conta.TipoConta} ---");
    Console.WriteLine($"Saldo inicial: R${conta.Saldo:F2}");
    Console.WriteLine($"Tarifa de manutenção: R${conta.CalcularValorTarifaManutencao():F2}");

    conta.Depositar(100.0);
    try
    {
        conta.Sacar(250.0); // algumas contas vão gerar erro
    }
    catch (Exception ex)
    {
        Console.WriteLine($"[EXCEÇÃO] {ex.Message}");
    }

    Console.WriteLine($"Saldo final: R${conta.Saldo:F2}");
}
