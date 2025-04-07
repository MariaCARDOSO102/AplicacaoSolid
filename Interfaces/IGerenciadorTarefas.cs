using AplicacaoSolid.Entities;

namespace AplicacaoSolid.Interfaces;

public interface IGerenciadorTarefas
{
    public void CriarTarefa(Tarefa tarefa);
    public List<Tarefa> ListarTarefas();
    public List<Tarefa> FiltrarPrioridade(int prioridade);
}
