using ConsoleLearning;

Point p1 = new Point();
p1.X = 7;
Point p2 = p1; // присваивание приводит к копированию


Console.WriteLine(p1.X); // 7
Console.WriteLine(p2.X); // 7

p1.X = 9; // изменяем p1.X

Console.WriteLine(p1.X); // 9
Console.WriteLine(p2.X); // 7