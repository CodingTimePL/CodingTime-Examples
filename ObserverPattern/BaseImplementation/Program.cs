namespace BaseImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var concreteSubject = new ConcreteSubject();
            var observer1 = new ConcreteObserver("Observer 1");
            var observer2 = new ConcreteObserver("Observer 2");

            concreteSubject.ConcreteSubjectState = 2;

            concreteSubject.Attach(observer1);
            observer1.Update(concreteSubject);

            concreteSubject.Attach(observer2);
            observer2.Update(concreteSubject);

            concreteSubject.ConcreteSubjectState = 3;

            concreteSubject.Detach(observer1);

            concreteSubject.ConcreteSubjectState = 4;
        }
    }
}