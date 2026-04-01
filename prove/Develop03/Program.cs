using System;

class Program
{
    static void Main(string[] args)
    {
        List<(Reference, string)> scriptures = new List<(Reference, string)>
        {
            (new Reference("Jacob", 4, 4),
            "For, for this intent have we written these things, that they may know that we knew of Christ, and we had a hope of his glory many hundred years before his coming; and not only we ourselves had a hope of his glory, but also all the holy prophets which were before us."),

            (new Reference("Philippians", 4, 13),
            "I can do all things through Christ which strengtheneth me."),

            (new Reference("Isaiah", 53, 6),
            "All we like sheep have gone astray; we have turned every one to his own way; and the Lord hath laid on him the iniquity of us all.")
        };

        Random rand = new Random();
        var chosen = scriptures[rand.Next(scriptures.Count)];

        Scripture scripture = new Scripture(chosen.Item1, chosen.Item2);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Program ended.");
    }
}