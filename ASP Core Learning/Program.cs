using ASP_Core_Learning.EFCore;


string[] names =
{
    "Tom",
    "Dick",
    "Harry",
    "Mary",
    "Jay"
};

using NutShellContext dbContext = new NutShellContext();


IEnumerable<string> query = names
    .Where(name => name.EndsWith("y"));