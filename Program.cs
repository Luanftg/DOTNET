internal class Program
{

    public static List<Produto> listaDeProduto = new List<Produto>();
    private static void Main(string[] args)
    {
        Console.WriteLine("""

        --------------------------------------------
        Bem vindo ao Sistema de Cadastro de Produto
        --------------------------------------------

        """);
        var opcao = 0;
        
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
                default:
                    opcao = 0;
                break;
            }
        } while(opcao >=0);
    }
static void menu(){
    Console.WriteLine("""
        Digite a opção desejada:
        ------------------------------------------
        0 -> Sair
        1 -> Cadastrar Produto
        2 -> Listar Produtos
        3 -> Exibir número de produtos cadastrados
        ------------------------------------------
        """);
    }

    static void cadastrar() {

        Console.WriteLine("\nInforme o nome do produto:\n");
        string? nome = Console.ReadLine();
        Console.WriteLine("\nInforme a quantidade do produto:\n");
        int? quantidade = Convert.ToInt32(Console.ReadLine());
        var produto = new Produto(nome, quantidade);
        Program.listaDeProduto.Add(produto);
        Console.WriteLine("\nProduto Cadastrado com sucesso!\n");
    }
    static void listar() {

        Console.WriteLine("\nLista de Produtos: \n");
        for(int index =0;index<Program.listaDeProduto.Count();index++)
        {
            Console.WriteLine(Program.listaDeProduto[index] + "\n");
        }
    }
    static void mostrarQuantidadeDaLista() {
        int? soma = 0;
        var quantidadeDaLista = Program.listaDeProduto.Count();
        for(int index =0;index<quantidadeDaLista;index++)
        {
            var produto = Program.listaDeProduto[index];
            Console.WriteLine("\n" + produto.nome + " : " + produto.quantidade);
            soma += produto.quantidade;
        }
        
        Console.WriteLine("\nQuantidade Atual de Produtos no estoque: " + soma + "\n");
        
    }
}

public class Produto
{
   private int id;
   public string? nome;
   public int? quantidade;

    public Produto(string? nome, int? quantidade)
    {
     this.nome = nome; 
     this.quantidade = quantidade;
     this.id = Program.listaDeProduto.Count+1; 
    }

    public override string? ToString()
    {
        return "id: " + this.id + "\nnome: " +  this.nome + "\nquantidade: " + this.quantidade ;
    }
}