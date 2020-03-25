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