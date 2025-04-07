namespace AplicacaoSolid.Entities;

public class ConsoleTarefa
{
    public static int ShowOptions()
    {
        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.WriteLine("                             Gerenciador de Tarefas                             ");
        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("1 - Criar tarefas");
        Console.WriteLine("2 - Listar tarefas");
        Console.WriteLine("3 - Marcar como concluída");
        Console.WriteLine("4 - Filtrar por prioridade");
        Console.WriteLine("5 - Exibir relatório");
        Console.WriteLine("0 - Encerrar");
        Console.Write("-> ");
        int opt = int.Parse(Console.ReadLine()!);

        Console.WriteLine();

        return opt;
    }
}
