namespace Strategy.Strategies
{
    internal class WaterGun : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("attacks with a water gun");
        }
    }
}
