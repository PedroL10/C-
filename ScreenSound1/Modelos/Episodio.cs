class Episodio
{

    List<string> convidados = new List<string>();  
    public Episodio(int duracao, int ordem, string titulo)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }

    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - Convidados: " +
        $"{string.Join(", ",convidados)}.";

    public void AdicionarConvidados(string convidado)
    { 
        convidados.Add(convidado);
    }
}