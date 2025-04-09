using AplicacaoSolid.Entities;
using AplicacaoSolid.Interfaces;

IGerenciadorTarefas gerenciadorTarefas = new GerenciadorTarefas();

while (true)
{
    string opt = ConsoleTarefa.ShowOptions();
    List<Tarefa> tarefas = gerenciadorTarefas.Listar();
    var tarefaPrinter = new TarefaPrinter();

    switch (opt)
    {
        case "1":
            Console.Write("Titulo da tarefa: ");
            string titulo = Console.ReadLine()!;

            Console.Write("Prioridade (1-5): ");
            int prioridade = int.Parse(Console.ReadLine()!);

            gerenciadorTarefas.Criar(new Tarefa(titulo, prioridade));
            break;

        case "2":
            tarefaPrinter.Print(tarefas);
            break;

        case "3":
            tarefaPrinter.Print(tarefas);

            Console.Write($"Selecione a tarefa a ser marcada (1 a {tarefas.Count}): ");
            int index = int.Parse(Console.ReadLine()!);

            tarefas[index-1].MarcarConcluida();
            break;

        case "4":
            Console.Write("Digite a prioridade (1-5): ");
            int prio = int.Parse(Console.ReadLine()!);

            var tarefasFiltradas = gerenciadorTarefas.FiltrarPrioridade(prio);
            tarefaPrinter.Print(tarefasFiltradas);
            break;


        case "5":
            var relatorio = new RelatorioTarefa(gerenciadorTarefas);
            relatorio.Print();
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;

        case "0":
            return;
    }
}