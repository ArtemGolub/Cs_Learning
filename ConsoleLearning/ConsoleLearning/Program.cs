using ConsoleLearning.Enumerations;

FibbonachyIterator fibbonachyIterator = new FibbonachyIterator();
foreach (int fib in 
         fibbonachyIterator.EvenNumbersOnly(
             fibbonachyIterator.Fibs(6)))
{
    Console.WriteLine(fib);
}
