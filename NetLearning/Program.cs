using System.Xml;

string s = XmlConvert.ToString(24);
Console.WriteLine(s);

int isTrue = XmlConvert.ToInt32(s);
Console.WriteLine(isTrue);