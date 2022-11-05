namespace Observer
{
    public class Observable
    {
        List<IObserver> observers = new List<IObserver>();

        public void Add(IObserver o)
        {
            observers.Add(o);
        }

        public void Remove(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObserver()
        {
            foreach (var item in observers)
            {
                IObserver o = item;
                o.Update(this);
            }
        }
    }
}