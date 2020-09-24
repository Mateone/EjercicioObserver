using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            IObservable sensor = new TemperatureSensor();
            IObserver reporter = new TemperatureReporter();
            reporter.StartReporting(sensor);
            sensor.GetTemperature();
        }
    }
}