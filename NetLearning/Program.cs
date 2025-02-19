
int i = (int) BorderSides.Top;
BorderSides side = (BorderSides) i;
Console.WriteLine(GetIntegralValueAsString(side));


static int GetIntegralValue(Enum anyEnum) => (int)(object)anyEnum;

static object GetBoxedIntegralValue(Enum anyEnum)
{
    Type integralType = Enum.GetUnderlyingType(anyEnum.GetType());
    Console.WriteLine(integralType);
    return Convert.ChangeType(anyEnum, integralType);
}

static decimal GetAnyIntegerValue(Enum anyEnum) => Convert.ToDecimal(anyEnum);

static string GetIntegralValueAsString (Enum anyEnum) => anyEnum.ToString("D");