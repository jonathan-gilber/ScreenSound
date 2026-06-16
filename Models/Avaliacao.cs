namespace ScreenSound.Models;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        if (nota > 10) Nota = 10;
        if (nota < 0) Nota = 0;
        Nota = nota;
    }
    public int Nota {get; }

    public static Avaliacao Parse(string value)
    {
        int nota = int.Parse(value);
        return new Avaliacao(nota);
    }
}