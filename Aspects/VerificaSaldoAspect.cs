using AspectInjector.Broker;
using BancoAspectos.Models;

namespace BancoAspectos.Aspects;

[Aspect(Scope.Global)]
[Injection(typeof(VerificaSaldoAspect))]
public class VerificaSaldoAspect
{
    [Advice(Kind.Before, Targets = Target.Method)]
    public void VerificarSaldo([Argument(Source.Instance)] object instance,
                                [Argument(Source.Arguments)] object[] args,
                                [Argument(Source.Name)] string methodName)
    {
        if (instance is Conta conta && methodName == "Sacar" && args.Length > 0 && args[0] is double valor)
        {
            if (conta.Saldo < valor)
            {
                Console.WriteLine($"[ERRO] Saldo insuficiente na conta {conta.TipoConta}. Saldo: R${conta.Saldo:F2}, Saque: R${valor:F2}");
                throw new InvalidOperationException("Saldo insuficiente para saque.");
            }
        }
    }
}
