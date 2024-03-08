namespace Proxy
{
    internal interface IChief
    {
        Dictionary<int, string> GetStatuses();
        IEnumerable<Order> GetOrders();
    }
}
