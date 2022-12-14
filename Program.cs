using System.Text.Json;

internal class Program
{
    const string CAMINHO_ARQUIVOS = "/Users/Luan Fonseca/Desktop/Codigo do Futuro/DOTNET/Imports";
    const string CAMINHO_NOME_ARQUIVO = "/Users/Luan Fonseca/Desktop/Codigo do Futuro/DOTNET/data/pessoas.json";
    public static string[]? arquivos = Directory.GetFiles(CAMINHO_ARQUIVOS);
    public static List<Produto> listaDeProdutos = new List<Produto>();
    public static List<Cliente> listaDeClientes = new List<Cliente>();
    public static List<Pessoa> listaDePessoas = new List<Pessoa>();
    private static void Main()
    {
        //listarPessoas("F");
        Console.WriteLine("""

        -----------------------------------
        Bem vindo ao Sistema de Cadastro
        -----------------------------------

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
                case "6":
                    cadastrarPessoas("F");
                    opcao =0;
                    break;
                case "7":
                    listarPessoas("F");
                    opcao =0;
                    break;
                case "8":
                    cadastrarPessoas("J");
                    opcao =0;
                    break;
                case "9":
                    listarPessoas("J");
                    opcao =0;
                    break;
                default:
                    opcao = 0;
                break;
            }
        } while(opcao >=0);
    }

    public static void cadastrarPessoas(string tipo) {
        var listaLocal = File.ReadAllText(CAMINHO_NOME_ARQUIVO);
        List<Pessoa> listaDePessoasLocais = JsonSerializer.Deserialize<List<Pessoa>>(listaLocal)!;

        Console.WriteLine("Informe o nome do Usuário");
        string? nome = Console.ReadLine();
        Console.WriteLine("Informe o numero do documento");
        string? documento = Console.ReadLine();
        switch (tipo)
        {
            case "F":
            Usuario usuario = new Usuario(nome!,documento!);
            listaDePessoasLocais.Add(usuario);
                break;
            case "J":
            Fornecedor fornecedor = new Fornecedor(nome!,documento!);
            listaDePessoasLocais.Add(fornecedor);
                break;
            
            default:
                break;
        }

        string jsonString = JsonSerializer.Serialize(listaDePessoasLocais);
        File.WriteAllText(CAMINHO_NOME_ARQUIVO, jsonString);
    }

    public static void listarPessoas(string tipo) {
        string jsonString = File.ReadAllText(CAMINHO_NOME_ARQUIVO);
        List<Pessoa> listaDePessoas = JsonSerializer.Deserialize<List<Pessoa>>(jsonString)!;
        foreach (Pessoa pessoa in listaDePessoas)
        {
            if(tipo == pessoa.Tipo) {
                Console.WriteLine(pessoa);
            }
        }
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
    }

    private static void atualizaListaLocal(){
        foreach (string arq in arquivos!)
        {
            string jsonString = File.ReadAllText(arq);
            Cliente cliente = JsonSerializer.Deserialize<Cliente>(jsonString)!;
            bool contains = Program.listaDeClientes.Contains(cliente);
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
        Cliente cliente = new Cliente() {Nome = nomeDoCliente, Telefone = telefone};
        string fileName = "client"+ (cliente.Id).ToString() + ".json";
        string directoryName = "C:\\Users\\Luan Fonseca\\Desktop\\Codigo do Futuro\\DOTNET\\Imports\\" + fileName;
        
        string jsonString = JsonSerializer.Serialize(cliente);
        File.WriteAllText(directoryName, jsonString);
        Console.WriteLine("Cliente Cadastrado com sucesso!");
        atualizaArquivosLocais();
        atualizaListaLocal();
    }

    static void menu() {
    Console.WriteLine("""

        Digite a opção desejada:
        ------------------------------------------
        0 -> Sair
        1 -> Cadastrar Produto
        2 -> Listar Produtos
        3 -> Exibir número de produtos cadastrados
        4 -> Cadastrar Cliente
        5 -> Listar Clientes
        6 -> Cadastrar Usuários
        7 -> Listar Usuarios
        8 -> Cadastrar Fornecedor
        9 -> Listar Fornecedor
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