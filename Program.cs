class UniqueQuiz
{
    static public void Main(String[] args)
    {
        bool isEnd = false;
        char decision;
        while (!isEnd)
        {
            string dna = Console.ReadLine();
            if (IsValidSequence(dna))
            {
                Console.WriteLine("Current DNA sequence: {0}", dna);
                Console.WriteLine("Do you want to replicate it? (Y/N): ");
                while (true)
                {
                    char decision1 = char.Parse(Console.ReadLine());
                    if (decision1 == 'Y')
                    {
                        Console.WriteLine("Replicated DNA sequence: {0}", ReplicateSequence(dna));
                        break;
                    }
                    else if (decision1 == 'N')
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please input Y or N.");
                    }
                }

            }
            else
            {
                Console.WriteLine("The DNA sequence is invalid.");
            }

            Console.WriteLine("Do you want to process another sequence? (Y/N): ");
            isEnd = ReturnProgram();
        }
    }


    static bool ReturnProgram()
    {
        char decision = char.Parse(Console.ReadLine());
        if (decision == 'N')
        {
            return true;
        }
        else if (decision == 'Y')
        {
            return false;
        }
        else
        {
            return ReturnProgram();
        }
    }

    static bool IsValidSequence(string dnaSequence)
    {
        foreach (char nucleotide in dnaSequence)
        {
            if (!"ATCG".Contains(nucleotide))
            {
                return false;
            }
        }
        return true;
    }

    static string ReplicateSequence(string dnaSequence)
    {
        string result = "";
        foreach (char nucleotide in dnaSequence)
        {
            result += "TAGC"["ATCG".IndexOf(nucleotide)];
        }
        return result;
    }
}