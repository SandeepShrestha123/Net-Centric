using System;
class TemperatureSensor
{
    public delegate void ThresholdHandler(double temp);
    public event ThresholdHandler ThresholdCrossed;
    private double threshold;
    public TemperatureSensor(double threshold)
    {
        this.threshold = threshold;
    }
    public void SetTemperature(double temp)
    {
        Console.WriteLine("Current Temp: " + temp);
        if (temp > threshold)
        {
            ThresholdCrossed?.Invoke(temp);
        }
    }
}
class Program
{
    static void AlertUser(double temp)
    {
        Console.WriteLine("ALERT! Temp " + temp + " crossed threshold!");
    }
    static void Main()
    {
        TemperatureSensor sensor = new TemperatureSensor(30);
        sensor.ThresholdCrossed += AlertUser;
        sensor.SetTemperature(25);
        sensor.SetTemperature(35);
        Console.ReadKey();
    }
}