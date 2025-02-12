using ConsoleLearning.SpecialTypes;

MathOperations mathOperations = new MathOperations();
Transformer t = mathOperations.Square;
int answer = t(5);
Console.WriteLine(answer);