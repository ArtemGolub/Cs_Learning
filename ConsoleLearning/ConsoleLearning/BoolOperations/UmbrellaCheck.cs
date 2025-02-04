namespace ConsoleLearning.BoolOperations;

public class UmbrellaCheck
{
    public static bool UseUmbrella(bool rainy, bool sunny, bool windy)
    {
        return !windy && (rainy || sunny);
    }
}