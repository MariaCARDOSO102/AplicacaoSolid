using AplicacaoSolid.Interfaces;
using System.Threading.Tasks;

namespace AplicacaoSolid.Entities;

public class GerenciadorTarefas : IGerenciadorTarefas
{
    private readonly List<Tarefa> Tarefas = [];

    public void Criar(Tarefa tarefa)
    {
        Tarefas.Add(tarefa);
    }

    public List<Tarefa> Listar()
    {
        return Tarefas;
    }

    public List<Tarefa> FiltrarPrioridade(int prioridade)
    {
        return Tarefas.Where(t => t.Prioridade == prioridade).ToList();
    }
}
