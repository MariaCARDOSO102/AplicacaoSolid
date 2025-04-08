using AplicacaoSolid.Entities;
using AplicacaoSolid.Interfaces;

// TODO Terminar as operações
// TODO Criar classe Printer

IGerenciadorTarefas gerenciadorTarefas = new GerenciadorTarefas();

while (true)
{
    string opt = ConsoleTarefa.ShowOptions();
    List<Tarefa> tarefas = gerenciadorTarefas.ListarTarefas();


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
            foreach (Tarefa ta in tarefas)
            {
                ta.Print();
            }
            return;

        case "4":

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