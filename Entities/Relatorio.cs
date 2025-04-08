using AplicacaoSolid.Interfaces;

namespace AplicacaoSolid.Entities;

public class Relatorio : IPrintavel
{
    private readonly IGerenciadorTarefas _gerenciadorTarefas;

    public Relatorio(IGerenciadorTarefas gerenciadorTarefas)
    {
        _gerenciadorTarefas = gerenciadorTarefas;
    }

    public void Print()
    {
        Console.WriteLine("  ____                                 ");
        Console.WriteLine(" |  _ \\ ___  ___ _   _ _ __ ___   ___  ");
        Console.WriteLine(" | |_) / _ \\/ __| | | | '_ ` _ \\ / _ \\ ");
        Console.WriteLine(" |  _ <  __/\\__ \\ |_| | | | | | | (_) |");
        Console.WriteLine(" |_| \\_\\___||___/\\__,_|_| |_| |_|\\___/ ");
        Console.WriteLine("                                       ");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("");

        List<Tarefa> tarefas = _gerenciadorTarefas.ListarTarefas();
        int total = tarefas.Count;
        int concluidas = CalcularConcluidas(tarefas);

        Console.WriteLine($"[{concluidas}/{total}] Tarefas concluídas.");
        Console.WriteLine($"Ainda restam {total - concluidas} tarefas a serem feitas.");
        Console.WriteLine("\n\n");
    }

    private int CalcularConcluidas(List<Tarefa> tarefas)
    {
        int concluidas = 0;

        foreach (Tarefa tarefa in tarefas)
        {
            if (tarefa.EstaConcluida())
            {
                concluidas++;
            }
        }

        return concluidas;
    }
}
