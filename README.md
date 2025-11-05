--- Projeto DIO: Sistema Bancário com Programação Orientada a Objetos e Orientada a Aspectos
Este projeto tem como objetivo demonstrar a aplicação dos paradigmas de Programação Orientada a Objetos (POO) e Programação Orientada a Aspectos (POA) em um sistema bancário. 
O sistema permite que clientes realizem operações de saque em diferentes tipos de conta, enquanto uma função transversal (verificação de saldo) é aplicada de forma automática e centralizada usando POA.

--- Objetivos do Projeto

- Implementar um sistema bancário com múltiplos tipos de conta usando POO.
- Aplicar uma função transversal (verificação de saldo) com POA, interceptando chamadas ao método Sacar() em todas as contas.
- Demonstrar como separar responsabilidades e evitar duplicação de lógica usando aspectos.

--- Tipos de Conta Implementados

| Tipo de Conta     | Tarifa de Manutenção |
|-------------------|----------------------|
| Corrente          | R$ 12,50             |
| Salário           | R$ 0,00              |
| Poupança          | R$ 0,00              |
| Investimento      | R$ 25,00             |

--- Função Transversal: Verificação de Saldo

A verificação de saldo é aplicada automaticamente antes de qualquer saque. Se o saldo for insuficiente, uma mensagem de erro é exibida e a operação é bloqueada.

--- Exemplos de Saída
Código
--- Corrente ---
Saldo inicial: R$100.00
Tarifa de manutenção: R$12.50
[INFO] Depósito de R$100.00 realizado.
[ERRO] Saldo insuficiente na conta Corrente. Saldo: R$200.00, Saque: R$250.00
[EXCEÇÃO] Saldo insuficiente para saque.
Saldo final: R$200.00

-- Paradigmas Demonstrados
POO: Herança, encapsulamento, abstração, polimorfismo
POA: Aspecto de verificação de saldo aplicado a múltiplas classes sem duplicação de código
