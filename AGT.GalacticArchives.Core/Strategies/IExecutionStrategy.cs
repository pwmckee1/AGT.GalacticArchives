namespace AGT.GalacticArchives.Core.Strategies;

public interface IExecutionStrategy
{
    void Execute(IExecutionContext context);
}