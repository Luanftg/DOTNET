# Primeiro programa em .NET

## Desafio Inicial

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

## Desafio Complementar

*Faça um programa que*

- [x] leia itens de importação

*para isso você terá que criar um programa para*

- [x] ler arquivos json
- [x] transformar estes arquivos em objetos
- [x] armezenar os clientes na lista em memória
- [x] mostrar o resultado na tela como um relatório

*Terá uma pasta imports com os arquivos:*

*imports
    cliente1.json
    cliente2.json
    cliente3.json
    cliente4.json
    cliente5.json*

    Conteúdo do arquivo:
        {"nome": "Danilo", "telefone": "123432123"}

## Introdução .NET

- Linguagem de Programação **C#**
  - Compilada e fortemente tipada
  - Estatica e dinamica
  - Exemplo de declaração `int numero = 1`
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

- `class`
- `struct`
- `record`

Acessores
- `public`
- `internal` = a nivel de projeto
- `private`
- `protected`

Construtores

- Sobrecarga
- Vazio
- Literais ``new Client() {Nome = Luan, idade= 34}``

### Referências

[Microsoft - Serialização e Desserialização](https://learn.microsoft.com/pt-br/dotnet/standard/serialization/system-text-json/how-to?pivots=dotnet-7-0)

[Linha de Código - Diretórios e Arquivos com DotNet](http://www.linhadecodigo.com.br/artigo/3684/trabalhando-com-arquivos-e-diretorios-em-csharp.aspx)
