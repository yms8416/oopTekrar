using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BilgeAdam.OOP.StockManagement.Helpers
{
    public class TextHelper
    {
        private static Random rnd = new Random();
        public static string GenerateCode()
        {
            var code = rnd.Next(100000000, 999999999);
            var result = Regex.Replace(code.ToString(), @"^(.{3})(.{4})(.{2})$", "$1-$2-$3");
            return result;
        }
    }
}
