string GetWeightCatergory(decimal bmi) => bmi switch
{
    < 18.5m => "Underweight",
    < 25m => "Normal",
    < 30m => "Overweight",
    _ => "Obese"
};

int x = 0;
if(x is > 100)
    Console.WriteLine("x is greater than 100");