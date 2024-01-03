namespace TicketDataAggregator.FileAccess
{
    public interface IDocumentsReader
    {
        IEnumerable<string> Read(string directory);
    }
}