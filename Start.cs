using System;
using System.Collections.Generic;
using System.Linq;

public class Start{
    public static void Main(string[] args)
    {
        //ExecuteInheritance();
        //ExecuteVehicleFactory();
        //ExecuteFuncPlayGround();
        //ExecuteFuncGenericPlayground();
        //ExecuteFuncGenericPlaygroundWithObject();
        //ExecuteGetComplicatedValue();
        ExecuteShapeBucketTest();
    }

    public static void ExecuteShapeBucketTest(){
        var sb = new ShapeBucket<Red>();

        sb.AddShape(new RedTriangle());
        sb.AddShape(new RedCircle());

        var result = sb.FindShapes(s => s.Edges >= 0);
        foreach(var shape in result) {
            Console.WriteLine($"{shape.GetType()} with {shape.Edges} edge(s).");
        }
    }

    public static void ExecutePalindrome(){
        Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
    }

    public static void ExecuteInheritance(){
        Pet pet = new Cat();
        Shape shape = new Ball();
        Console.WriteLine(string.Format($"My {pet.GetName()} is playing with a {shape.GetName()}"));
    }

    public static void ExecutePath(){
        Path path = new Path("/a/b/c/d");
        path.Cd("../x");
        Console.WriteLine(path.CurrentPath);
    }

    public static void ExecuteVehicleFactory(){
        var car = VehicleFactory.Create<Car>();
        var concreteCar = (Car)car;
        concreteCar.PaintVehicle("Black");

        var motorbike = VehicleFactory.Create<Motorbike>();
        var concreteMotorbike = (Motorbike)motorbike;

        Console.WriteLine($"Car has {car.NumberOfWheels} wheels and the colour is {concreteCar.PaintColour}");
        Console.WriteLine($"Motorbike has {motorbike.NumberOfWheels} wheels and the colour is {concreteMotorbike.PaintColour}");
    }

    public static void ExecuteFuncPlayGround() {
        var funcPlayground = new FuncPlayground();

        var results = funcPlayground.ExecutePredicate(l => l.Length == 5).ToList();

        Console.WriteLine($"Found {results.Count} items");
        foreach (var item in results)
        {
            Console.WriteLine(item);
        }
    }

    public static void ExecuteFuncGenericPlayground() {
        var list = new List<string>() {"Apple", "Orange", "Watermelon", "Mango", "Grapes", "Banana"};

        var funcGenericPlayground = new FuncGenericPlayground<string>(list);

        var results = funcGenericPlayground.ExecutePredicate(l => l.Length > 5).ToList();

        Console.WriteLine($"Found {results.Count} items");
        foreach (var item in results)
        {
            Console.WriteLine(item);
        }
    }

    public static void ExecuteFuncGenericPlaygroundWithObject() {
        var list = new List<IVehicle>() {new Car("Black"), new Car("Red"), new Car("Grey"), new Car(), new Motorbike(), new Motorbike("Red")};

        var funcGenericPlayground = new FuncGenericPlayground<IVehicle>(list);

        var results = funcGenericPlayground.ExecutePredicate(v => v.PaintColour == "White").ToList();

        Console.WriteLine($"Found {results.Count} items");
        /* foreach (var item in results)
        {
            Console.WriteLine($"{item.ToString()}");
        } */
    }

    public static void ExecuteGetComplicatedValue() {
        var getComplicatedValue = new GetComplicatedValue();

        var result = getComplicatedValue.GetValue(3, 1, 2);

        Console.WriteLine(result);
    }
}