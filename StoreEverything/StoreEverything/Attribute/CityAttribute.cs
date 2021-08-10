using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreEverything.Attribute
{
    public class CityAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string cityName = value.ToString();
                if (!Char.IsDigit(cityName, 0))
                    return true;
                else
                    this.ErrorMessage = "City cannot contain numbers";
            }
            return false;
        }
    }
}