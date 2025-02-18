object obj = "Some";
if (obj is string { Length: 4 })
    Console.WriteLine("It's a string with 4 characters");
