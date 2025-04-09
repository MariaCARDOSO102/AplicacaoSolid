using AplicacaoSolid.Entities;

namespace AplicacaoSolid.Interfaces;

public interface IGerenciadorTarefas : IGerenciador<Tarefa>
{
    public List<Tarefa> FiltrarPrioridade(int prioridade);
}
