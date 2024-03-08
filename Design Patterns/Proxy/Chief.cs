namespace Proxy
{
    internal class Chief : IChief
    {
        public Dictionary<int, string> GetStatuses()
        {
            Thread.Sleep(2000);
            return new Dictionary<int, string>
            {
                { 1, "Ready" },
                { 2, "Not Ready" },
                { 3, "Preparing" }
            };
        }

        public IEnumerable<Order> GetOrders()
        {
            return new List<Order>
            {
                new() {Name = "Burger",StatusId = RandomizeStatus()},
                new() {Name = "Pizza",StatusId = RandomizeStatus()},
                new() {Name = "Sushi",StatusId = RandomizeStatus()}
            };
        }



        private static int RandomizeStatus() => new Random().Next(1, 4);
    }
}
