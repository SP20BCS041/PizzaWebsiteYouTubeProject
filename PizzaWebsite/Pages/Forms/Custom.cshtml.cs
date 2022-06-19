using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaWebsite.Models;


namespace PizzaWebsite.Pages.Forms
{
    public class CustomModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
             PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrice +=  1;
            if (Pizza.Chesee) PizzaPrice +=  1;
            if (Pizza.Paperoni) PizzaPrice +=  1;
            if (Pizza.Tuna) PizzaPrice +=  1;
            if (Pizza.Beef) PizzaPrice +=  1;
            if (Pizza.Ham) PizzaPrice +=  1;
            if (Pizza.Mashroom) PizzaPrice +=  1;
            if (Pizza.Pineapple) PizzaPrice +=  1;

            return RedirectToPage("/Checkout/Checkout" , new {Pizza.PizzaName, PizzaPrice });
        }
    }
}
