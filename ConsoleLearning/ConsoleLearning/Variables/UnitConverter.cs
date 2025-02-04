namespace ConsoleLearning.Variables;

public class UnitConverter
{
    private int _ratio;

    public UnitConverter(int ratio)
    {
        _ratio = ratio;
    }
    public int Convert(int unit)
    {
        return unit * _ratio;
    }
}