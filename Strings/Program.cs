using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args) //best practice kodlama yapılırken daha iyi yol aranır
        {
            //Intro();

            string sentence = "My name is Engin Demiroğ";
            var result = sentence.Length;
            var result2 = sentence.Clone();

            sentence = "My name is Derin Demiroğ";

            bool result3 = sentence.EndsWith("ğ");              //ğ ile biteni aramak
            bool result4 = sentence.StartsWith("My Name");      //My name ile başlayanı aramak
            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");            //aramaya sondan başlar
            var result8 = sentence.Insert(0, "Hello, ");        //cümlenin başına ekler
            var result9 = sentence.Substring(3, 4);                //belli bir değerden itibaren alınması
            var result10 = sentence.ToLower();              //bütün karakterleri küçüğe çevirir.
            var result11 = sentence.ToUpper();              //bütün karakterleri büyüğe çevirir.
            var result12 = sentence.Replace("a", "-");              //ifade edilen simgeye, ifade edilen simgeyi koyar
            var result13 = sentence.Remove(3,4);             //bir metinden belli bir indexten sonrasını atmak için kullnaılır



            Console.WriteLine(result13);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";


            Console.WriteLine(string.Format("{0}  {1}", city, city2));
        }
    }
}
