using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public abstract class Vehicle
{
    public abstract void display();
}

public class car : Vehicle
{
    public override void display()
    {
        Console.WriteLine("car");
    }
}

public class scooty : Vehicle
{
    public override void display()
    {
        Console.WriteLine("scooty");
    }
}

public class Motorcycle : Vehicle
{
    public override void display()
    {
        Console.WriteLine("Motorcycle");
    }
}

public class MyClass
{
    public static void Main()
    {
        Vehicle v;
        v = new car();
        v.display();
        v = new scooty();
        v.display();
        v = new Motorcycle();
        v.display();
        Console.ReadLine();
    }
}
