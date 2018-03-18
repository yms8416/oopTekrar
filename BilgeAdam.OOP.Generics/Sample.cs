using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.OOP.Generics
{
    public class Sample
    {
        public static void GenericCall()
        {
            #region Giriş
            var numbers = new int[10];
            numbers[0] = 2;
            numbers[1] = 5;
            numbers[2] = 12;
            numbers[3] = -7;

            var spells = new string[] { "a", "b", "c", "d", "e" };

            var cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Zonguldak");
            cities.Add("Çorum");
            cities.Add("Mardin");

            var numberList = new List<int>();
            numberList.Add(2);
            numberList.Add(5);
            numberList.Add(19);
            numberList.Add(22);
            numberList.Add(45);
            numberList.Add(-3);

            var q = new Question();
            q.Add("Can");
            q.Add(3);
            #endregion

            var a = new Answer<string>();
            a.Add("Can");

            var b = new Answer<int>();
            b.Add(3);

            var c = new Answer<TestEnum>();
            c.Add(TestEnum.V1);
            c.Add(TestEnum.V2);
            c.Add(TestEnum.V3);

            var d = new Answer<Question>();
            d.Add(new Question());
        }
    }
    /// <summary>
    /// bir methodum var adı Add ve hem string hem int parametre alabiliyor. Nasıl yaparım?
    /// cevap soruda yapıldı ama KEKO yöntem ile
    /// </summary>
    class Question
    {
        public void Add(string value)
        {

        }

        public void Add(int value)
        {

        }

        public void Add(bool value)
        {

        }

        //half keko - half cool yöntem
        public void Add(object value)
        {

        }
    }

    class Answer<T>
    {
        public void Add(T value)
        {

        }
    }

    enum TestEnum
    {
        V1 = 0,
        V2 = 1,
        V3 = 2
    }
}
