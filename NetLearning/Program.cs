using NetLearning.Equality;

Area a1 = new Area(5, 10);
Area a2 = new Area(10, 5);

Console.WriteLine(a1.Equals(a2));
Console.WriteLine(a1 == a2);