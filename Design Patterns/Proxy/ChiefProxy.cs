
namespace Proxy
{
    internal class ChiefProxy : IChief
    {
        private readonly Chief _chief;

        private Dictionary<int, string>? _statuses;

        public ChiefProxy(Chief chief)
        {
            _chief = chief;
        }
        public IEnumerable<Order> GetOrders()
        {
            return _chief.GetOrders();
        }

        public Dictionary<int, string> GetStatuses()
        {
            if (_statuses is null)
            {
                _statuses = _chief.GetStatuses();
            }
            return _statuses;
        }
    }
}
