using System.Text.Json;

internal class Program
{
    const string CAMINHO_ARQUIVOS = "/Users/Luan Fonseca/Desktop/Codigo do Futuro/DOTNET/Imports";
    public static string[]? arquivos = Directory.GetFiles(CAMINHO_ARQUIVOS);
    public static List<Produto> listaDeProdutos = new List<Produto>();
    public static List<Cliente> listaDeClientes = new List<Cliente>();
    private static void Main()
    {
        Console.WriteLine("""

        --------------------------------------------
        Bem vindo ao Sistema de Cadastro de Produto
        --------------------------------------------

        """);
        var opcao = 0;
        atualizaListaLocal();
        
        do {
            menu();
            string? resultOpcao = Console.ReadLine();

            switch (resultOpcao)
            {
                case "0":
                opcao =-1;
                    break;
                case "1":
                    cadastrar();
                    opcao = 0;
                    break;
                case "2":
                    listar();
                    opcao =0;
                    break;
                case "3":
                    mostrarQuantidadeDaLista();
                    opcao =0;
                    break;
                case "4":
                    cadastrarCliente();
                    opcao =0;
                    break;
                case "5":
                    listarClientes();
                    opcao =0;
                    break;
                default:
                    opcao = 0;
                break;
            }
        } while(opcao >=0);
    }

    private static void listarClientes()
    {
        foreach (Cliente client in listaDeClientes)
        {   
            Console.WriteLine(client);
        }
    }

    private static void atualizaArquivosLocais() {
        Program.arquivos = Directory.GetFiles(CAMINHO_ARQUIVOS);
        foreach (var arq in arquivos)
        {
            Console.WriteLine(arq);
        }
    }

    private static void atualizaListaLocal(){
        foreach (string arq in arquivos!)
        {
            string jsonString = File.ReadAllText(arq);
            Cliente cliente = JsonSerializer.Deserialize<Cliente>(jsonString)!;
            bool contains = Program.listaDeClientes.Contains(cliente);
            Console.WriteLine("Contains: " + contains.ToString());
            if(contains == false)
            {
                Program.listaDeClientes.Add(cliente);
            }
        }
    }

    private static void cadastrarCliente()
    {
        Console.WriteLine("\nInforme o nome do cliente:\n");
        string? nomeDoCliente = Console.ReadLine();
        Console.WriteLine("\nInforme o telefone do cliente:\n");
        string? telefone = Console.ReadLine();
        Cliente cliente = new Cliente(nomeDoCliente!,telefone!);
        string fileName = "client"+ (cliente.Id).ToString() + ".json";
        string directoryName = "C:\\Users\\Luan Fonseca\\Desktop\\Codigo do Futuro\\DOTNET\\Imports\\" + fileName;
        Console.WriteLine(directoryName);

        
        string jsonString = JsonSerializer.Serialize(cliente);
        Console.WriteLine(cliente.ToString());
        File.WriteAllText(directoryName, jsonString);
        atualizaArquivosLocais();
        atualizaListaLocal();
    }

    static void menu(){
    Console.WriteLine("""

        Digite a opção desejada:
        ------------------------------------------
        0 -> Sair
        1 -> Cadastrar Produto
        2 -> Listar Produtos
        3 -> Exibir número de produtos cadastrados
        4 -> Cadastrar Cliente
        5 -> Listar Clientes
        ------------------------------------------
        """);
    }

    static void cadastrar() {

        Console.WriteLine("\nInforme o nome do produto:\n");
        string? nome = Console.ReadLine();
        Console.WriteLine("\nInforme a quantidade do produto:\n");
        int? quantidade = Convert.ToInt32(Console.ReadLine());
        var produto = new Produto(nome, quantidade);
        Program.listaDeProdutos.Add(produto);
        Console.WriteLine("\nProduto Cadastrado com sucesso!\n");
    }
    static void listar() {

        Console.WriteLine("\nLista de Produtos: \n");
        for(int index =0;index<Program.listaDeProdutos.Count();index++)
        {
            Console.WriteLine(Program.listaDeProdutos[index] + "\n");
        }
    }
    static void mostrarQuantidadeDaLista() {
        int? soma = 0;
        var quantidadeDaLista = Program.listaDeProdutos.Count();
        for(int index =0;index<quantidadeDaLista;index++)
        {
            var produto = Program.listaDeProdutos[index];
            Console.WriteLine("\n" + produto.Nome + " : " + produto.Quantidade);
            soma += produto.Quantidade;
        }
        
        Console.WriteLine("\nQuantidade Atual de Produtos no estoque: " + soma + "\n");
        
    }
}

public class Produto
{
   private int Id;
   public string? Nome;
   public int? Quantidade;

    public Produto(string? nome, int? quantidade)
    {
     this.Nome = nome; 
     this.Quantidade = quantidade;
     this.Id = Program.listaDeProdutos.Count+1; 
    }

    public override string? ToString()
    {
        return "id: " + this.Id + "\nnome: " +  this.Nome + "\nquantidade: " + this.Quantidade ;
    }
}

public class Cliente {

    public int Id {get;}
    public string? Nome {get;set;}
    public string? Telefone {get;set;}

    public Cliente(string nome, string telefone)
    {
        this.Nome = nome;
        this.Telefone = telefone;
        this.Id = Program.listaDeClientes.Count+1;
    }

     public override string? ToString()
    {
        return "\nnome: " +  this.Nome + "\ntelefone: " + this.Telefone ;
    }
}