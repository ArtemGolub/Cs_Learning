using System.ComponentModel;
using System.Drawing;

TypeConverter cc = TypeDescriptor.GetConverter(typeof(Color));

Color biege = (Color) cc.ConvertFromString("Beige")!;
Color purple = (Color) cc.ConvertFromString("Purple")!;
