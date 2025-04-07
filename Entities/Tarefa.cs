using AplicacaoSolid.Interfaces;

namespace AplicacaoSolid.Entities;

public class Tarefa : IConcluivel, IPrintavel
{
    public string Titulo { get; set; }
    public int Prioridade { get; set; }
    private bool Concluida { get; set; }

    public Tarefa(string titulo, int prioridade)
    {
        Titulo = titulo;
        Prioridade = prioridade;
        Concluida = false;
    }

    public void MarcarConcluida()
    {
        Concluida = true;
    }

    public bool EstaConcluida()
    {
        return Concluida;
    }

    public void Print()
    {
        Console.WriteLine($"[{(Concluida ? "X" : " ")}] {Titulo} (Prioridade: {Prioridade})");
    }
}
