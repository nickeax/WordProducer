namespace WordProducer;

public class Alphabet
{
    public List<char> All { get; set; } = [];
    public List<char> Vowels { get; set; } = [];
    public List<char> Consonants { get; set; } = [];

    public Alphabet()
    {
        Vowels = [.. "aeiou"];
        Consonants = [.. "bcdfghjklmnpqrstvwxyz"];
        All.AddRange(Vowels);
        All.AddRange(Consonants);
    }

    public bool IsVowel(char c) => Vowels.Contains(c);
}
