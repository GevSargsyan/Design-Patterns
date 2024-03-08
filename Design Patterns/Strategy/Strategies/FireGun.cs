namespace Strategy.Strategies
{
    internal class FireGun : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("attacks with a fire gun");
        }
    }
}
