using System;

// Abstract class "Car"
abstract class Car
{
    public abstract int GetSpeed();
    public abstract void PressBrake();
    public abstract void PressGas();
}

// Concrete class Audi, inherits from Car
class Audi : Car
{
    private int speed;

    public override int GetSpeed()
    {
        return speed;
    }

    public override void PressBrake()
    {
        speed -= 10;
        Console.WriteLine("Audi: Pressed brake. Current speed: " + speed);
    }

    public override void PressGas()
    {
        speed += 10;
        Console.WriteLine("Audi: Pressed gas. Current speed: " + speed);
    }
}

// Concrete class BMW, inherits from Car
class BMW : Car
{
    private int speed;

    public override int GetSpeed()
    {
        return speed;
    }

    public override void PressBrake()
    {
        speed -= 15;
        Console.WriteLine("BMW: Pressed brake. Current speed: " + speed);
    }

    public override void PressGas()
    {
        speed += 15;
        Console.WriteLine("BMW: Pressed gas. Current speed: " + speed);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Audi
        Audi audi = new Audi();
        Console.WriteLine("Audi. Initial speed: " + audi.GetSpeed());
        audi.PressGas();
        audi.PressGas();
        audi.PressBrake();
        audi.PressBrake();

        // Create an instance of BMW
        BMW bmw = new BMW();
        Console.WriteLine("BMW. Initial speed: " + bmw.GetSpeed());
        bmw.PressGas();
        bmw.PressGas();
        bmw.PressBrake();
        bmw.PressBrake();
    }
}
