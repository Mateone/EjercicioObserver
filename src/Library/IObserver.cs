using System;

namespace Observer
{
    public interface IObserver
    {
        void StartReporting(IObservable provider);
        void StopReporting();
        void Update();
    }
}