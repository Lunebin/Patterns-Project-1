namespace ET_Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Uncomment sections here as you implement them

            // Create our HeavyObjects (DO NOT MODIFY THESE VALUES)
            HeavyObject lightest = new HeavyObject(10, 10, 1, 1);
            HeavyObject medium = new HeavyObject(7, 7, 2, 5);
            HeavyObject heavyAndSmall = new HeavyObject(5, 5, 5, 50);

            
            // Create lists of the HeavyObjects and print them for debug purposes
            HeavyObjectList listA = new HeavyObjectList();
            listA.Add(heavyAndSmall);
            listA.Add(medium);
            listA.Add(lightest);
            Console.WriteLine("ListA:");
            listA.Print();
            Console.WriteLine();

            HeavyObjectList listB = new HeavyObjectList();
            listB.Add(medium);
            listB.Add(lightest);
            listB.Add(heavyAndSmall);
            Console.WriteLine("ListB:");
            listB.Print();
            Console.WriteLine();

            HeavyObjectList listC = new HeavyObjectList();
            listC.Add(lightest);
            listC.Add(medium);
            listC.Add(heavyAndSmall);
            Console.WriteLine("ListC:");
            listC.Print();
            Console.WriteLine();
            
            HeavyObjectList listD = new HeavyObjectList();
            listD.Add(new HeavyObject(5, 4, 4, 6));
            listD.Add(new HeavyObject(2, 5, 2, 3));
            listD.Add(new HeavyObject(5, 6, 3, 8));
            listD.Add(new HeavyObject(2, 5, 7, 8));
            Console.WriteLine("ListD:");
            listD.Print();
            Console.WriteLine();

            // list E
            HeavyObjectList listE = new HeavyObjectList();
            listE.Add(new HeavyObject(2, 5, 2, 3));
            listE.Add(lightest);
            listE.Add(medium);
            listE.Add(new HeavyObject(5, 6, 5, 8));
            listE.Add(new HeavyObject(5, 4, 4, 6));
            listE.Add(new HeavyObject(5, 6, 3, 8));
            listE.Add(new HeavyObject(2, 5, 7, 8));
            listE.Add(heavyAndSmall);
            Console.WriteLine("ListE:");
            listE.Print();
            Console.WriteLine();

            // Create our Flyweight Factory and create the Flyweights out of it
            FlyweightFactory fw = new FlyweightFactory();
            StackingStrategy bottomWeight = fw.GetFlyweight("bottomWeight");
            StackingStrategy pyramid = fw.GetFlyweight("pyramid");
            StackingStrategy topple = fw.GetFlyweight("topple");

            // Print results
            Console.WriteLine("BottomWeight - ListA: " + bottomWeight.EvaluateStack(listA));
            Console.WriteLine("BottomWeight - ListB: " + bottomWeight.EvaluateStack(listB));
            Console.WriteLine("BottomWeight - ListC: " + bottomWeight.EvaluateStack(listC));
            Console.WriteLine("BottomWeight - ListD: " + bottomWeight.EvaluateStack(listD));
            Console.WriteLine("BottomWeight - ListE: " + bottomWeight.EvaluateStack(listE));
            Console.WriteLine();
            Console.WriteLine("Pyramid - ListA: " + pyramid.EvaluateStack(listA));
            Console.WriteLine("Pyramid - ListB: " + pyramid.EvaluateStack(listB));
            Console.WriteLine("Pyramid - ListC: " + pyramid.EvaluateStack(listC));
            Console.WriteLine("Pyramid - ListD: " + pyramid.EvaluateStack(listD));
            Console.WriteLine("Pyramid - ListE: " + pyramid.EvaluateStack(listE));
            Console.WriteLine();
            Console.WriteLine("Topple - ListA: " + topple.EvaluateStack(listA));
            Console.WriteLine("Topple - ListB: " + topple.EvaluateStack(listB));
            Console.WriteLine("Topple - ListC: " + topple.EvaluateStack(listC));
            Console.WriteLine("Topple - ListD: " + topple.EvaluateStack(listD));
            Console.WriteLine("Topple - ListE: " + topple.EvaluateStack(listE));
        }
    }
}