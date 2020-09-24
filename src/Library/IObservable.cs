using System.Threading;
using System;
using System.Collections.Generic;

namespace Observer
{
    public interface IObservable
    {

        Temperature Current { get; set; }
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);

        void GetTemperature();
    }
}