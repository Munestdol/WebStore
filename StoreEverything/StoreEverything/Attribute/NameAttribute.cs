using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreEverything
{
    public class NameAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
    {
        if (value != null)
        {
            string userName = value.ToString();
            if (!Char.IsDigit(userName,0))
                return true;
            else
                this.ErrorMessage = "Name cannot contain numbers";
        }
        return false;
    }
    }
}