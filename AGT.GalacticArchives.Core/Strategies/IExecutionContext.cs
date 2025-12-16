namespace AGT.GalacticArchives.Core.Strategies;

public interface IExecutionContext
{
    HashSet<string> Errors { get; set; }

    void Execute();

    void ExecuteAll();
}