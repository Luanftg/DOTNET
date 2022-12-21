public class Fornecedor : Pessoa{
    public Fornecedor(string nome, string documento) {
        this.Nome = nome;
        this.Documento = documento;
        this.Id = Program.listaDePessoas.Count() +1;
        this.Tipo = "J";
    }
}