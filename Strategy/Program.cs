using Strategy;

Console.WriteLine("Strategy");

Person p = new Person("José");
p.Move(new RunMovement(), 50);