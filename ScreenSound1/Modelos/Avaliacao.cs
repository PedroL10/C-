namespace ScreenSound1.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota) 
    {
        if (nota <= 0) Console.WriteLine("Nota inválida"); nota = 0;
        if (nota >= 10) Console.WriteLine("Nota inválida"); nota = 10;
        Nota = nota;
    }

    public int Nota { get; }
public static Avaliacao Parse(String texto)
{ 
    int nota = int.Parse(texto);
    return new Avaliacao(nota);
}
}
