using System;

// Interface for radio functionality
interface IRadio
{
    void TurnOn();
    void TurnOff();
    void ChangeStation();
    void IncreaseVolume();
}

// Interface for seat functionality
interface ISeats
{
    void AdjustPosition();
    void HeatOn();
    void HeatOff();
}

// Abstract class "Car"
abstract class Car : IRadio, ISeats
{
    protected int speed;

    public int GetSpeed()
    {
        return speed;
    }

    public void PressBrake()
    {
        speed -= GetBrakeCoefficient();
        PrintBrakeInfo(speed);
    }

    public void PressGas()
    {
        speed += GetAccelerationCoefficient();
        PrintGasInfo(speed);
    }

    protected abstract int GetBrakeCoefficient();
    protected abstract int GetAccelerationCoefficient();
    protected abstract void PrintBrakeInfo(int speed);
    protected abstract void PrintGasInfo(int speed);

    public void TurnOn()
    {
        Console.WriteLine("Radio turned on.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Radio turned off.");
    }

    public void ChangeStation()
    {
        Console.WriteLine("Changing radio station.");
    }

    public void IncreaseVolume()
    {
        Console.WriteLine("Increasing radio volume.");
    }

    public void AdjustPosition()
    {
        Console.WriteLine("Adjusting seat position.");
    }

    public void HeatOn()
    {
        Console.WriteLine("Seat heating turned on.");
    }

    public void HeatOff()
    {
        Console.WriteLine("Seat heating turned off.");
    }
}

// Concrete class Audi, inherits from Car
class Audi : Car
{
    protected override int GetBrakeCoefficient()
    {
        return 10;
    }

    protected override int GetAccelerationCoefficient()
    {
        return 10;
    }

    protected override void PrintBrakeInfo(int speed)
    {
        Console.WriteLine("Audi: Pressed brake. Current speed: " + speed);
    }

    protected override void PrintGasInfo(int speed)
    {
        Console.WriteLine("Audi: Pressed gas. Current speed: " + speed);
    }
}

// Concrete class BMW, inherits from Car
class BMW : Car
{
    protected override int GetBrakeCoefficient()
    {
        return 15;
    }

    protected override int GetAccelerationCoefficient()
    {
        return 15;
    }

    protected override void PrintBrakeInfo(int speed)
    {
        Console.WriteLine("BMW: Pressed brake. Current speed: " + speed);
    }

    protected override void PrintGasInfo(int speed)
    {
        Console.WriteLine("BMW: Pressed gas. Current speed: " + speed);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Audi
        Car audi = new Audi();
        Console.WriteLine("Audi. Initial speed: " + audi.GetSpeed());
        audi.TurnOn();
        audi.ChangeStation();
        audi.IncreaseVolume();
        audi.PressGas();
        audi.AdjustPosition();
        audi.HeatOn();
        audi.PressBrake();
        audi.HeatOff();
        audi.TurnOff();

        // Create an instance of BMW
        Car bmw = new BMW();
        Console.WriteLine("BMW. Initial speed: " + bmw.GetSpeed());
        bmw.TurnOn();
        bmw.ChangeStation();
        bmw.IncreaseVolume();
        bmw.PressGas();
        bmw.AdjustPosition();
        bmw.HeatOn();
        bmw.PressBrake();
        bmw.HeatOff();
        bmw.TurnOff();
    }
}
