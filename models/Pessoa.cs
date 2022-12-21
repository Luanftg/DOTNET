public class Pessoa {
    public int Id {get;set;}
    public string Nome {get;set;} = default!;
    public string Documento {get;set;} = default!;
    public string? Tipo {get;set;}

     public override string? ToString()
    {
        return "\nId:" + this.Id + "\nnome: " +  this.Nome + "\nDocumento: " + this.Documento + "\nTipo:" + this.Tipo;
    }
}