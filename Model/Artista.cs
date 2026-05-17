class Artista
{
    public Artista(string nome, string funcao)
    {
        Nome = nome;
        Funcao = funcao;
    }
    public string Nome { get; }
    public int Idade { get; set; }
    public string Funcao { get; }
    public string Detalhes => $"Nome: {Nome}, Idade: {Idade}, Funcao: {Funcao}";
}