using System.Collections.Generic;

namespace BaseImplementation
{
    public class ConcreteSubject : ISubject
    {
        public int ConcreteSubjectState
        {
            get => _concreteSubjectState;
            set
            {
                _concreteSubjectState = value;
                Notify();
            }
        }
        private int _concreteSubjectState;

        private readonly List<IObserver> _observers = new List<IObserver>();
        
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}