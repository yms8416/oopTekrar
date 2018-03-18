using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.OOP.Generics
{
    public class SampleGenerics
    {
        public static IEnumerable<string> IEnumerables()
        {
            #region Generic List
            //var list = new List<string> { "Elma", "Armut", "Vişne", "Kiraz", "Karpuz" };
            //list.Add("Şeftali");
            //list.Remove("Armut");
            //list.Insert(2, "Muz");
            //var add1 = new List<string> { "Ananas", "Mango", "Papaya" };
            //list.AddRange(add1);
            //if (!list.Contains("Armut"))
            //{
            //    list.Add("Armut");
            //} 
            #endregion

            #region HashSet
            //var list = new HashSet<string> { "Elma", "Armut", "Elma", "Kiraz", "Elma", "Kiraz", "Karpuz" };
            //list.Add("Armut");
            //list.Add("Muz");
            #endregion

            #region Linked List
            //var list = new LinkedList<string>();
            //list.AddLast("Muz");
            //var first = list.AddFirst("Elma");
            //var amt = list.AddAfter(first, "Armut");
            //list.AddAfter(amt, "Kiraz");
            //list.AddBefore(amt, "Vişne");
            #endregion

            #region Sorted Set
            var list = new SortedSet<string> { "Elma", "Armut", "Elma", "Vişne", "Muz", "Karpuz", "Şeftali" };
            #endregion

            return list;
        }

        public static Dictionary<int, string> Dictionaries()
        {
            //SortedList<int, string>
            var dict = new Dictionary<int, string>();
            dict.Add(2, "Adıyaman");
            dict.Add(5, "Amasya");
            dict.Add(1, "Adana");
            dict.Add(3, "Afyon");
            dict.Add(4, "Ağrı");
            dict.Add(5, "Ankara");
            return dict;
        }
    }
}
