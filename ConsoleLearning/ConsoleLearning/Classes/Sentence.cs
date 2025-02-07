namespace ConsoleLearning.Classes;

public class Sentence
{
    string[] words = "The quick brown fox jumps over the lazy dog".Split(' ');

    public string this[int wordNum]
    {
        get { return words[wordNum];}
        set { words[wordNum] = value; }
    }
}