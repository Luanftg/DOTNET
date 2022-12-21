public class Cliente {

    public int Id {get;}
    public string? Nome {get;set;}
    public string? Telefone {get;set;}

    public Cliente()
    {
        this.Id = Program.listaDeClientes.Count+1;
    }

     public override string? ToString()
    {
        return "\nnome: " +  this.Nome + "\ntelefone: " + this.Telefone ;
    }
}