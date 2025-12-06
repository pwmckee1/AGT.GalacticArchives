namespace AGT.GalacticArchives.Core.Strategies;

public class ValidationContext : IExecutionContext
{
    private HashSet<IExecutionStrategy> _strategies = [];

    public HashSet<string> Errors { get; set; } = [];

    public static IExecutionContext CreateContext(HashSet<IExecutionStrategy> strategies)
    {
        return new ValidationContext { _strategies = strategies };
    }

    public void Execute()
    {
        foreach (var strategy in _strategies)
        {
            strategy.Execute(this);
            if (Errors.Count != 0)
            {
                return;
            }
        }
    }

    public void ExecuteAll()
    {
        foreach (var strategy in _strategies)
        {
            strategy.Execute(this);
        }
    }
}