
Type targetType = typeof(int);
object source = "42";
object result = Convert.ChangeType(source, targetType);

Console.WriteLine(result);
Console.WriteLine(result.GetType());