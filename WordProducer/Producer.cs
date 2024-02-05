using System.Text;

namespace WordProducer;

public class Producer
{
    public Alphabet Alphabet { get; set; } = new Alphabet();
    public string GenerateWord(int length)
    {
        bool isVowel = false;
        char previous = '|';
        char current = '|';
        Random random = new Random();

        var word = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            current = Alphabet.All[random.Next(0, Alphabet.All.Count - 1)];
            if (previous == '|')
            {
                previous = current;
            }
            else
            {
                if (Alphabet.IsVowel(previous))
                {
                    current = Alphabet.Consonants[random.Next(0, Alphabet.Consonants.Count - 1)];
                    previous = current;

                    word.Append(current);
                    if(current == 'q')
                    {
                        word.Append('u');
                    }
                }
                else
                {
                    for (int j = 1; j <= random.Next(1,3); j++)
                    {
                        current = Alphabet.Vowels[random.Next(0, Alphabet.Vowels.Count - 1)];
                        word.Append(current);
                    }

                    previous = current;
                }
            }

        }

        return word.ToString();
    }
}

/*
We now need an iterator that will randomly select a character and decide what to do based on the class of the 
new character and the class of the previous character. The Iterator will have a State that will be set based on 
the most recently selected character. The State will be used to determine the next character.
 */