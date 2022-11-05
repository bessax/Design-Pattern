using Observer;

Console.WriteLine("Observer");

ConcreteObserver observadorconcreto1 = new ConcreteObserver();
ConcreteObserver observadorconcreto2 = new ConcreteObserver();

Observable observable = new Observable();
observable.Add(observadorconcreto1);
observable.Add(observadorconcreto2);

observable.NotifyObserver();
