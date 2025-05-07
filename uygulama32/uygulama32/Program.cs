using System;

namespace uygulama32
{
    class Program
    {

        class Dog
        {
           public string breed;

            public void bark()
            {
                Console.WriteLine("Bark! Bark! ");
            }

        }


        static void Main(string[] args)
        {
            Dog bullDog = new Dog();

            bullDog.breed = "Bull Dog";
            Console.WriteLine(bullDog.breed);


            bullDog.bark();





        }
    }
}
