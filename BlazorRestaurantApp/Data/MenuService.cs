using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorRestaurantApp.Data
{
    public interface IMenuService
    {
        MenuItems[] GetMenu()
    }

    public class MenuService : IMenuService
    {
         public MenuItems[] GetMenu()
        {
            return new MenuItems[]
            {
                new MenuItems{ Entree = "Steak", Price = 20, Side = "Fries"},
                new MenuItems{ Entree = "Soup", Price = 10, Side = "Salad"},
                new MenuItems{ Entree = "Spaghetti", Price = 10, Side = "Toast"}
            };

        } 
    }
}
