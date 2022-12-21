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