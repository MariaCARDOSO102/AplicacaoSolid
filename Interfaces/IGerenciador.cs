namespace AplicacaoSolid.Interfaces;

public interface IGerenciador<T>
{
    public void Criar(T registro);
    public List<T> Listar();
}
