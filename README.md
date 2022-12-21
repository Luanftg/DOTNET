# Primeiro programa em .NET

## Estrutura geral

![Alt text](abstra%C3%A7%C3%A3o.png)

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

## DEsafio Complementar 2

Crie uma aplicação console onde terá um cadastro de pessoas no geral
este cadastro de pessoas vai armazenar pessoas fisicas ou juridicas

JSON com pessoa, fisica ou juridica

Tem que ter uma tela de menu, onde vc escolhe a opção de cadastro, se for pessoa fisica, utilizará o modelo de pessoa fisica, se juridica
utilizará o modelo de pessoa juridica

porem o serviço para gravar o json, salva no mesmo local, independente se é fisica ou juridica, gravando um json assim

pessoas.json
[
  { Id: 1,  Nome: 'Gustavo', Documento: '333.333.333-99', Tipo: 'F'},
  { Id: 1,  Nome: 'Portes e Transportes LTDA', Documento: '00.000.000/0000-00', Tipo: 'J'}
]

Voce terá uma classe Usuario com as propriedades
Id:  Nome, CPF

Voce terá uma classe Fornecedor com as propriedades
Id:  Nome, CNPJ

Inclusão de dados

Leitura da tabela na tela de um app console

### Referencias

[escreve arquivo](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-write-to-a-text-file)
[ler arquivo](https://www.educative.io/answers/how-to-read-a-text-file-in-c-sharp)
[serialize e deserialize json c#](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/how-to?pivots=dotnet-7-0)

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

[Apostila - DEVOPS](https://docs.google.com/presentation/d/1175LVx-Us1CCIaENIglvmZ87-npBDAVOyBRG90VwaaY/edit#slide=id.gf5d14fb323_0_0)

Luan Fonseca
  - Logica de programação = 10
  - Inclusão e Listagem de dados Angular = 8
  - Usando HTTP, POST, PUT, GET, DELTE = 9
  - Orientação a Objetos = 8