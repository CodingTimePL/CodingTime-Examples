using System;

namespace BaseImplementation
{
    public class ConcreteObserver : IObserver
    {
        private readonly string _observerName;

        public ConcreteObserver(string observerName) => _observerName = observerName;

        public void Update(ISubject subject)
        {
            Console.WriteLine($"{_observerName}: {(subject as ConcreteSubject)?.ConcreteSubjectState}");
        }
    }
}