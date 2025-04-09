namespace AplicacaoSolid.Interfaces;

public interface IPrinter<T>
{
    public void Print(List<T> values);
}
