using WordProducer;

var wordProducer = new Producer();
var rnd = new Random();

for (int ii = 1; ii <= 2000; ii++)
{
    for (int i = 0; i < 5; i++)
        Console.Write("{0,-20}",wordProducer.GenerateWord(rnd.Next(4, 10)));
    Console.WriteLine();
}