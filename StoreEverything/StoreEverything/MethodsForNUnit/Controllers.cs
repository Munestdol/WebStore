using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreEverything.MethodsForNUnit
{
    public class Controllers
    {
        public float startPrice = 700;
        public string SetCategory(string category)
        {
            if (category != null && category.Length >= 3 && category.Length <= 15 && !Char.IsDigit(category, 0))
                return category;
            else if (category == "")
                return "The field is empty";
            else if (category.Length < 3 || category.Length > 15)
                return "Invalid number of characters";
            else
                return "Is not a string";
        }

        public string SetName(string name)
        {
            if (name != null && name.Length >= 3 && name.Length <= 15 && !Char.IsDigit(name, 0))
                return name;
            else if (name == "")
                return "The field is empty";
            else if (name.Length < 3 || name.Length > 15)
                return "Invalid number of characters";
            else
                return "Is not a string";
        }
        public string SetAdress(string adress)
        {
            if (adress != null && adress.Length >= 3 && adress.Length <= 15)
                return adress;
            else if (adress == "")
                return "The field is empty";
            else
                return "Invalid number of characters";
        }
        public bool CheckPage(int page)
        {
            if (page > 0 && page < 10)
                return true;
            else
                return false;
        }

        public string Addition(double price)
        {
            if (price > 0)
                return Convert.ToString(price+startPrice);
            else
                return "You entered a negative amount";
        }

        public string SetCity(string city)
        {
            if (city != null && city.Length >= 3 && city.Length <= 15 && !Char.IsDigit(city, 0))
                return city;
            else if (city == "")
                return "The field is empty";
            else if (city.Length < 3 || city.Length > 15)
                return "Invalid number of characters";
            else
                return "Is not a string";
        }
    }
}