namespace TheSpacedevsAPI_test
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Retrieving all available agencies...");
            var agencies = await new ApiCalls().GetAgenciesList();

            foreach (var item in agencies.Results)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}