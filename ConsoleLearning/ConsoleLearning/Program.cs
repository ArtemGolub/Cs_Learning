using ConsoleLearning;

UnitConverter feetToInchesConverter = new UnitConverter(12);
UnitConverter milesToFettConverter = new UnitConverter(5280);

Console.WriteLine(feetToInchesConverter.Convert(30));
Console.WriteLine(feetToInchesConverter.Convert(100));
Console.WriteLine(feetToInchesConverter.Convert(milesToFettConverter.Convert(1)));