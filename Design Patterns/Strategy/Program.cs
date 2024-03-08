using Strategy.Strategies;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new("Name");
            hero.SetWeapon(new FireGun());
            hero.Attack();
            hero.SetWeapon(new WaterGun());
            hero.Attack();
        }


    }
}
