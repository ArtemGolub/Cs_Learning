using NetLearning.Formatting_and_Parsing;

ToString_Parse<int> parser = new ToString_Parse<int>();

int parsingString = 1;
string? s = parser.Convert(parsingString);
parsingString = 0;
Console.WriteLine(parsingString);
parsingString = parser.DeConvert(s);
Console.WriteLine(parsingString);