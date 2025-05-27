using System;

namespace Homework001_extend;
class Animal { }
class Dog : Animal
{
    public void Bark() => Console.WriteLine("Woof woof");
}
class Cat : Animal
{
    public void Meow() => Console.WriteLine("Meow meow");
}

class TypeCastTest
{
    public static void Run()
    {
        Animal animal = new Dog();
        Animal animal1 = new Cat();

        Dog dog = animal as Dog;
        if (dog != null)
        {
            dog.Bark();
        }
        else
        {
            Console.WriteLine("Not a dog!");
        }

        if (animal1 is Cat cat)
        {
            cat.Meow();
        }
        else
        {
            Console.WriteLine("Not a cat!");
        }
    }
}
