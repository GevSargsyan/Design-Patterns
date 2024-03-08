namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IChief chief = new ChiefProxy(new Chief());
            while (true)
            {
                Thread.Sleep(2000);
                Console.Clear();

                Console.WriteLine("Welcome to Cooker");
                Console.WriteLine("--------- Orders --------");
                IEnumerable<Order> orders = chief.GetOrders();
                foreach (Order order in orders)
                {
                    string status = chief.GetStatuses().First(x => x.Key == order.StatusId).Value;
                    Console.WriteLine($"{order.Name}\t\t {status}");
                }
            }
        }
    }
}
