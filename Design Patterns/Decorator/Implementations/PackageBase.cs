using Decorator.Interfaces;

namespace Decorator.Implementations
{
    public abstract class PackageBase : IPackage
    {
        public abstract decimal CalculateValue();

        public abstract decimal CalculateWeight();

        public virtual decimal CalculateShippingCosts() => 0.0M;

        public virtual decimal CalculatePaymentCommision() => 0.0M;

        public virtual string DisplayPackageInfo() => $"Weight: {CalculateWeight()}; " +
            $"Price: {CalculateValue()}; " +
            $"Shipping Price: {CalculateShippingCosts()}; " +
            $"Commission for the Payment: {CalculatePaymentCommision()}.";
    }
}