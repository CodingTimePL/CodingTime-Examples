using System.Collections.Generic;

namespace BaseImplementation
{
    public class ConcreteSubject : ISubject
    {
        List<IObserver> observers = new List<IObserver>();
        
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }
    }
}