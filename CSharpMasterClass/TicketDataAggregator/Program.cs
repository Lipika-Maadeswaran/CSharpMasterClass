using TicketDataAggregator.FileAccess;
using TicketDataAggregator.TicketAggreation;

namespace TicketDataAggregator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string TicketsFolder = @"Tickets";

            try
            {
                var ticketsAggregator = new TicketsAggregator(
                    TicketsFolder,
                    new FileWriter(),
                    new DocumentsFromPdfsReader());

                ticketsAggregator.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occurred. " +
                    "Exception message: " + ex.Message);
            }

        }
    }
}