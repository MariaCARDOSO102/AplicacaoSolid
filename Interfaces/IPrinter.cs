using AplicacaoSolid.Entities;

namespace AplicacaoSolid.Interfaces;

public interface IPrinter
{
    public void PrintTask(List<Tarefa> tarefas);
}
