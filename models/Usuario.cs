public class Usuario: Pessoa {
    public Usuario(string nome, string documento) {
        this.Nome = nome;
        this.Documento = documento;
        this.Id = Program.listaDePessoas.Count() +1;
        this.Tipo = "F";
    }

      public override string? ToString()
    {
        return "\nId:" + this.Id + "\nnome: " +  this.Nome + "\nDocumento: " + this.Documento + "\nTipo:" + this.Tipo;
    }
}