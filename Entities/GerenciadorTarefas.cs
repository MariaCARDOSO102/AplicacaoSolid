using AplicacaoSolid.Interfaces;
using System.Threading.Tasks;

namespace AplicacaoSolid.Entities;

public class GerenciadorTarefas : IGerenciadorTarefas
{
    private readonly List<Tarefa> Tarefas = new List<Tarefa>();

    public void CriarTarefa(Tarefa tarefa)
    {
        Tarefas.Add(tarefa);
    }

    public List<Tarefa> ListarTarefas()
    {
        return Tarefas;
    }

    public List<Tarefa> FiltrarPrioridade(int prioridade)
    {
        return Tarefas.Where(t => t.Prioridade == prioridade).ToList();
    }
}
