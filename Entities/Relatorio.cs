using AplicacaoSolid.Interfaces;

namespace AplicacaoSolid.Entities;

public abstract class Relatorio : IPrintavel
{
    public abstract void Print();
}
