using System;
using Fourth;

namespace Fourth
{
    interface IFly
    {
        void Fly();
    }

    interface IWalk
    {
        void Walk();
    }

    public class Animals
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
    }

    public class Animal : Animals, IWalk
    {
        public void Walk()
            {
                Console.WriteLine(" I can walk.");
            }
        
    }

    public class Bird : Animals, IWalk, IFly
    {
        public void Walk()
            {
                Console.Write(" I can walk");
            }
        public void Fly()
        {
            Console.WriteLine(" and fly too.");
        }
    }
}

class Program4
{
    static void Main(string[] args)
    {
        //Cat
        Animal cat = new Animal();
        cat.Name = "I'm a Cat.";
        Console.Write("{0}", cat.Name);
        cat.Walk();
        //Hawk
        Bird hawk = new Bird();
        hawk.Name = "I'm a Hawk.";
        Console.Write("{0}", hawk.Name);
        hawk.Walk();
        hawk.Fly();
        //Dog
        Animal dog = new Animal();
        dog.Name = "I'm a Dog.";
        Console.Write("{0}",dog.Name);
        dog.Walk();
        //Pigeon
        Bird pigeon = new Bird();
        pigeon.Name = "I'm a Pigeon.";
        Console.Write("{0}", pigeon.Name);
        pigeon.Walk();
        pigeon.Fly();
    }
}
  