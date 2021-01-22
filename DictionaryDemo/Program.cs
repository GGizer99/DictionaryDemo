using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> players = new MyDictionary<int, string>(); 

            players.Add(35, "Cihan Topaloğlu");
            players.Add(4, "Tolga Ünlü");
            players.Add(53, "Lokman Gör");
            players.Add(88, "Özgür Özkaya");
            players.Add(38, "İbrahim Öztürk");
            players.Add(8, "Yekta Kurtuluş");
            players.Add(19, "Marco Paixao");

            Console.WriteLine("-----------Takım----------");
            for (int i = 0; i < players.Keys.Length; i++)
            {
                Console.WriteLine(+ players.Keys[i] + " - " +  players.Value[i]);
            }


            Console.WriteLine("-------------Oyuncu Sayısı------------");
            Console.WriteLine(players.Count);

           

            /*foreach (var number in players.Keys )
            {
                Console.WriteLine(number);
            }
            foreach (var name in players.Value)
            {
                Console.WriteLine(name);
            }*/

        }
    }
}
