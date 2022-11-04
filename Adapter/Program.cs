using Adapter;

//TemperatureClassAdapter adapter= new TemperatureClassAdapter();
//adapter.SetValue(30);
//Console.WriteLine(adapter.GetValueInFahrenheit());


Temperature t = new Temperature();
//t.SetValue(86);
TemperatureObjectAdapter adapter = new TemperatureObjectAdapter(t);
adapter.SetValue(30);
Console.WriteLine(adapter.GetValue());
Console.WriteLine(t.GetValue());