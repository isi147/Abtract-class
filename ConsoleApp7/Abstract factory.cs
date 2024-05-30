namespace ConsoleApp7
{
    abstract class Chair { }
    abstract class Sofa { }
    abstract class CoffeeTable { }


    class VictorianChair : Chair
    {
        public VictorianChair()
        {
            Console.WriteLine("VictorianChair");
        }
    }

    class VictorianSofa : Sofa
    {
        public VictorianSofa()
        {
            Console.WriteLine("VictorianSofa");
        }
    }

    class VictorianCoffeeTable : CoffeeTable
    {
        public VictorianCoffeeTable()
        {
            Console.WriteLine("VictorianCoffeeTable");
        }
    }
    class ModernChair : Chair
    {
        public ModernChair()
        {
            Console.WriteLine("ModernChair");
        }
    }
    class ModernSofa : Sofa
    {
        public ModernSofa()
        {
            Console.WriteLine("ModernSofa");
        }
    }
    class ModernCoffeeTable : CoffeeTable
    {
        public ModernCoffeeTable()
        {
            Console.WriteLine("ModernCoffeeTable");
        }
    }
    class ArtDecoChair : Chair { }
    class ArtDecoSofa : Sofa { }
    class ArtDecoCoffeeTable : CoffeeTable { }


    abstract class Factory
    {
        public abstract Chair CreateChair();
        public abstract Sofa CreateSofa();
        public abstract CoffeeTable CreateCoffeeTable();
    }

    class VictorianFactory : Factory
    {
        public override Chair CreateChair()
            => new VictorianChair();

        public override CoffeeTable CreateCoffeeTable()
            => new VictorianCoffeeTable();

        public override Sofa CreateSofa()
            => new VictorianSofa();
    }

    class ModernFactory : Factory
    {
        public override Chair CreateChair()
            => new ModernChair();

        public override CoffeeTable CreateCoffeeTable()
            => new ModernCoffeeTable();

        public override Sofa CreateSofa()
            => new ModernSofa();
    }
}
