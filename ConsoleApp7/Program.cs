////using System.Threading.Channels;

////class Program
////{

////    class Animal
////    {
////        public virtual void Sound()
////        {
////            Console.WriteLine("Animal Sound");
////        }
////    }
////    class Dog : Animal
////    {
////        public override void Sound()
////        {
////            Console.WriteLine("Bark Bark!!!");
////        }
////    }
////    class Cat : Animal
////    {
////        public override void Sound()
////        {
////            Console.WriteLine("Miyaw miyaw!!!");
////        }
////    }


////    static void Main(string[] args)
////    {
////        Animal animal = new Animal();
////        Dog dog = new Dog();
////        Cat cat = new Cat();


////        List<Animal> animals = new List<Animal>();
////        animals.Add(dog);
////        animals.Add(cat);
////        animals.Add(animal);

////        foreach (var item in animals)
////        {
////            item.Sound();
////        }

////        animals.ForEach(i=>i.Sound());
////    }



////}



//class Program
//{
//    abstract class Transport
//    {

//        public abstract void Travel();

//    }

//    class Car : Transport
//    {


//        public override void Travel()
//        {
//            Console.WriteLine("By car travel");
//        }
//    }

//    class Airplane : Transport
//    {
//        public override void Travel()
//        {
//            Console.WriteLine("By airplane travel");
//        }
//    }



//    static void Main(string[] args)
//    {

//    }
//}


//using ConsoleApp7;

//Factory factory = new VictorianFactory();

//factory.CreateChair();
//factory.CreateCoffeeTable();
//factory.CreateSofa();