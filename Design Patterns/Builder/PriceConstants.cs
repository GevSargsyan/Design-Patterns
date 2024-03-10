namespace Builder
{
    public static class PriceConstants
    {
        #region Meaths
        public const decimal AngusMeat = 1700m;
        public const decimal BeefMeat = 1450m;
        public const decimal ChickenMeat = 1200m;
        #endregion

        #region Cheeses
        public const decimal YellowCheese = 150m;
        public const decimal WhiteCheese = 200m;
        #endregion

        #region Breads
        public const decimal WhiteBread = 300m;
        public const decimal BlackBread = 400m;
        #endregion
        
        #region Vegetables
        public const decimal Onion = 25m;
        public const decimal Tomato = 30m;
        public const decimal Cucumber = 35m;
        #endregion

        #region Vegetables
        public const decimal WhiteSauce = 50m;
        public const decimal Ketchup = 30m;
        #endregion

        public static string GetFormattedPrice(decimal price)
        {
            return $"${price:F2}";
        }
    }

}
