# Primeiro programa em .NET

## Desafio

*Seu roberto é um comerciante e precisa de um sistema
para armazenar os produtos do seu armazem.
Crie um programa que tenha um menu mostrando as opções de cadastro.*

- [x] 1 - Cadastrar produto
- [x] 2 - Listar produtos cadastrados
- [x] 3 - Quantidade total de itens no estoque
- [x] 4 - Sair

No produto terá os *atributos*

- [x] id
- [x] nome
- [x] quantidade

## Introdução .NET

- Linguagem de Programação **C#**
  - Compilada e fortemente tipada
  - Estatica e dinamica
  - Exemplo de declaração `int numero =1`
  - Excelente gerência no uso de memória pela organização na estrutura dos tipos primitivos

- Exemplo de estrutura básica em **C#**

```c#
namespace DOTNET {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, World! " + args[0]);
        }
    }
}
```

- Conversão
  - `Convert.ToInt32()`

- AOT Ahead of Time - compilação total
- POT Part of time - compilação parcial
