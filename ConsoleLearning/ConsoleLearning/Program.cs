using ConsoleLearning.SpecialTypes;

Transformer transformer = MathOperations.Square;
Console.WriteLine(transformer(2));
transformer += MathOperations.Quad;
Console.WriteLine(transformer(2));

