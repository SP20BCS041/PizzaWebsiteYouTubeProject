using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaWebsite.Models;

namespace PizzaWebsite.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> FakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){
                ImageTitle="Margerita"
                ,PizzaName="Margerita",
                BasePrice=2,
                TomatoSauce=true,
                Chesee=true, 
                FinalPrice=4
            },
                    
            new PizzasModel(){
                ImageTitle="Bolognese"
                ,PizzaName="Bolognese",
                BasePrice=2,
                TomatoSauce=true,
                Chesee=true,
                Beef=true,
                FinalPrice=5
            },        
            new PizzasModel(){
                ImageTitle="Carbonara"
                ,PizzaName="Carbonara",
                BasePrice=2,
                TomatoSauce=true,
                Chesee=true,
                Ham=true,
                Pineapple=true,
                FinalPrice=15
            },        
            new PizzasModel(){
                ImageTitle="Hawaiian"
                ,PizzaName="Hawaiian",
                BasePrice=2,
                TomatoSauce=true,
                Chesee=true,
                Mashroom=true,
                Ham=true,
                FinalPrice=6
            },        
            new PizzasModel(){
                ImageTitle="MeatFeast"
                ,PizzaName="MeatFeast",
                BasePrice=2,
                TomatoSauce=true,
                Chesee=true,
                FinalPrice=4
            },        
            new PizzasModel(){
                ImageTitle="Mushroom"
                ,PizzaName="Mushroom",
                BasePrice=2,
                TomatoSauce=true,
                Chesee=true,
                FinalPrice=4
            },        
            new PizzasModel(){
                ImageTitle="Pepperoni"
                ,PizzaName="Pepperoni",
                BasePrice=2,
                TomatoSauce=true,
                Chesee=true,
                FinalPrice=4
            },        
            new PizzasModel(){
                ImageTitle="Seafood"
                ,PizzaName="Seafood",
                BasePrice=2,
                TomatoSauce=true,
                Chesee=true,
                FinalPrice=4
            },        
            new PizzasModel(){
                ImageTitle="Vegetarian"
                ,PizzaName="Vegetarian",
                BasePrice=2,
                TomatoSauce=true,
                Chesee=true,
                FinalPrice=4
            },
        };
        public void OnGet()
        {
        }
    }
}
