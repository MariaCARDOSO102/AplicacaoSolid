using AplicacaoSolid.Interfaces;

namespace AplicacaoSolid.Entities;

public class TarefaPrinter : IPrinter<Tarefa>
{
    public void Print(List<Tarefa> tarefas)
    {
        foreach (var tarefa in tarefas)
        {
            tarefa.Print();
        }
    }
}
