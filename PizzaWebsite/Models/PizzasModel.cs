namespace PizzaWebsite.Models
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; } = 2;
        public bool TomatoSauce { get; set; }
        public bool Chesee { get; set; }
        public bool Paperoni { get; set; }
        public bool Mashroom { get; set; }
        public bool Tuna { get; set; }
        public bool Pineapple { get; set; }
        public bool Beef { get; set; }
        public bool Ham { get; set; }
        public float FinalPrice { get; set; }
    }
}
