using AplicacaoSolid.Entities;
using AplicacaoSolid.Interfaces;

// TODO Terminar as operações

IGerenciadorTarefas gerenciadorTarefas = new GerenciadorTarefas();

while (true)
{
    string opt = ConsoleTarefa.ShowOptions();
    List<Tarefa> tarefas = gerenciadorTarefas.ListarTarefas();
    var tarefaPrinter = new TarefaPrinter();

    switch (opt)
    {
        case "1":
            Console.Write("Titulo da tarefa: ");
            string titulo = Console.ReadLine()!;

            Console.Write("Prioridade (1-5): ");
            int prioridade = int.Parse(Console.ReadLine()!);

            gerenciadorTarefas.CriarTarefa(new Tarefa(titulo, prioridade));
            break;

        case "2":
            tarefaPrinter.Print(tarefas);
            break;

        case "3":

            break;

        case "4":
            Console.Write("Digite a prioridade (1-5): ");
            int prio = int.Parse(Console.ReadLine()!);

            var tarefasFiltradas = gerenciadorTarefas.FiltrarPrioridade(prio);
            tarefaPrinter.Print(tarefasFiltradas);
            break;


        case "5":
            var relatorio = new Relatorio(gerenciadorTarefas);
            relatorio.Print();
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;

        case "0":
            return;
    }
}