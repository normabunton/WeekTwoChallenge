using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTwoChallenges
{
    class WeekTwoChallenges
    {
        static void Greeting(string[] args)
        {
            Greeter greeter = new Greeter();
            Console.WriteLine("Your Name");
            string name = Console.ReadLine();
            greeter.Hello(name);
            greeter.TimeOfDay();
            greeter.Farewell(name);
            Console.ReadLine();
        }
    }
    public class Greeter
    {
        public void Hello(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        public void Farewell(string name)
        {
            Console.WriteLine($"Farewell my friend, {name}");

        }
        public void TimeOfDay()
        {
            int timeOfDay = DateTime.Now.Hour;

            if (timeOfDay >= 0 && timeOfDay < 12)
                {
                Console.WriteLine("Good Morning");
            }
            else if (timeOfDay >= 12 && timeOfDay < 18)
            {
                Console.WriteLine("Good Afternoon");
            }
            else if (timeOfDay >= 18 && timeOfDay < 20)
            {
                Console.WriteLine("Good Evening");
            }
            else if (timeOfDay >= 20 && timeOfDay <= 23)
            {
                Console.WriteLine("Good NIght");
            }
        }


    }
}

//Build a class called Greeter. This class will hold our next few methods.
//Inside our new class, build a method that takes in a name as a parameter and then outputs (writes to the Console) hello to that person.
//Ex: If the method is given the name Joshua, the output should be "Hello Joshua"
//Build another method that outputs (writes to the Console) some sort of farewell to the name it is given as a parameter.
//Build a method that outputs (writes to the Console) Good Morning/Afternoon/Evening/Night depending on the time of day.
//New up (instantiate) an instance of your Greeter class inside your Main method. From this instance call all of the methods you've built out.
