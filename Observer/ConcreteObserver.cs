namespace Observer;

public class ConcreteObserver : IObserver
{
    public void Update(Observable o)
    {
        ObservableData data = (ObservableData)o;
        data.GetData();
    }
}