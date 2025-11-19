//using UnityEngine;
using System;
using System.Collections.Generic;

class Listknowledge
{
    static void Main(string[] args)
    {
        List<string> food = new List<string>();

        food.Add("pizza chevre-miel");
        food.Add("pizza burrata");
        food.Add("pizza margherita");

        food.Remove("pizza burrata");
        food.Insert(0, "gnocchis");
        //food.Sort();

        foreach (string a in food)
            Console.WriteLine(a);

        Console.WriteLine(food.Count + " dishes");
        Console.WriteLine("index de pizza margherita = " + food.IndexOf("pizza margherita"));
        Console.WriteLine(food.Contains("pizza burrata"));

        //-------------------------------

        List<Power> powers = new List<Power>();

        Power fire = new Power("fire type");
        Power water = new Power("water type");
        Power wind = new Power("wind type");

        powers.Add(fire);
        powers.Add(water);
        powers.Add(wind);

        foreach(Power pow in powers)
        {
            Console.WriteLine(pow.type);
        }
    }
    class Power
    {
        public string type;

        public Power(string type)
        {
            this.type = type;
        }
    }
}
