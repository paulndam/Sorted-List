using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Sorted_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            SortedList<string, Person> people = new SortedList<string, Person>();

            people.Add("Messi", new Person() {Name = "Messi",Club = ClubEnum.Barcelona, Age = 34 });
            people.Add("Balotelli", new Person() {Name = "Balotelli",Club = ClubEnum.Lyon, Age = 30 });
            people.Add("Rashford", new Person() {Name = "Rashford",Club = ClubEnum.ManU, Age = 20 });
            people.Add("Alisson", new Person() {Name = "Alisson",Club = ClubEnum.Liverpool, Age = 25 });

            foreach(KeyValuePair<string, Person> x in people){

                Console.WriteLine($"{x.Value.Name} who is {x.Value.Age} years old, plays for {x.Value.Club}.");
            }











        }
    }
}
