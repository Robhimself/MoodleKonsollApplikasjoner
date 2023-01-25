

const string hash = "#";
const string whiteSpace = " ";

// Methods for printing character using loops.
void PrintSpace(int times)
{
    for (var i = 0; i < times; i++)
    {
        Console.Write(whiteSpace);
    }
}

void PrintHash(int times)
{
    for (var i = 0; i < times; i++)
    {
        Console.Write(hash);
    }
}


/* 2-1 Write a program that produces the following shape:
########
 ######
  ####
   ## 
*/

void ShowHalfDiamond()
{
    const int lineLenght = 8;
    const int lines = 4;
 
    for (var i = 0; i < lines; i++)
    {
        var space = i;
        var symmetricSpace = space * 2;
        var totalHash = lineLenght - symmetricSpace;
        
        PrintSpace(i);
        PrintHash(totalHash);
        Console.WriteLine();
    }
    Console.WriteLine();
}

/*
2-2 Or how about:
   ##
  ####
 ######
########
########
 ######
  ####
   ##
*/

void ShowDiamond()
{
    const int lineLenght = 8;
    const int lines = 4;
 
    for (var i = lines; i > 0; i--)
    {
        var space = i;
        var symmetricSpace = i * 2;
        var totalHash = lineLenght - symmetricSpace;
        
        PrintSpace(space);
        PrintHash(totalHash);
        Console.WriteLine();
    }
    ShowHalfDiamond();
    Console.WriteLine();
}

/*
2-3 Here’s an especially tricky one:
#            #
 ##        ##
  ###    ###
   ########
   ########
  ###    ###
 ##        ##
#            #
*/

void ShowCross()
{
    const int lineLenght = 14;
    const int lines = 8;
 
    for (var i = 0; i < lines; i++)
    {
        int space, singleHash, totalHash, middleSpace;
        if (i < 4)
        {
            space = i;
            singleHash = i + 1;
            totalHash = singleHash * 2;
            middleSpace = lineLenght - totalHash - (space * 2);
        }
        else
        {
            space = lines - (i+1); // i = 4, 8 - 4+1 = 2. 
            singleHash = lines - i; // 3
            totalHash = singleHash * 2; // i = 5, 3*2 = 6
            middleSpace = lineLenght - totalHash - (space * 2); // 14 - 6 - 2*2 = 4
        }
        
        PrintSpace(space);
        PrintHash(singleHash);
        PrintSpace(middleSpace);
        PrintHash(singleHash);
        Console.WriteLine();
    }
    
    Console.WriteLine();
}

/*
2-9 Write a program that reads a line of text, counting the number of words,
identifying the length of the longest word, the greatest number of vowels
in a word, and/or any other statistics you can think of.
*/

int CountVowels(string word)
{
    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
    int vowelCount = 0;
    for (var i = 0; i < vowels.Length; i++)
    {
        for (var j = 0; j < word.Length; j++)
        {
            if (word[j] == vowels[i])
            {
                vowelCount++;
            }
        }
    }
    return vowelCount;
}

void ShowLineStats()
{
    Console.Write("Input a sentence to analyze: ");
    var userInput = Console.ReadLine(); // ?? throw new ArgumentNullException("Console.ReadLine()");
    var inputArray = userInput.Split(' ');
    var longestWord = inputArray.OrderByDescending( s => s.Length ).First();
    var mostVowels = new int[inputArray.Length];
    
        
    // Getting the word(s) with the most vowels.

    for (var i = 0; i < inputArray.Length; i++)
    {
        var amount = CountVowels(inputArray[i]);
        mostVowels[i] = amount;
    }

    var maxVowelValue = mostVowels.Max();
    var maxVowelIndex = mostVowels.ToList().IndexOf(maxVowelValue);
    
    
    //
    // if (mostVowels.Length == 0)
    // {
    //     Console.WriteLine("None of the words contain a vowel. Amazing...");
    // }
    // else if (mostVowels.Length > 1)
    // {
    //     var appendedWordString = "";
    //     foreach (var word in mostVowels)
    //     {
    //         appendedWordString = word + " " + appendedWordString;
    //     }
    //     Console.WriteLine($"The words with the most vowels are: {appendedWordString}.");
    // }
    // else
    // {
    //     Console.WriteLine($"The word with the most vowels is {mostVowels[maxVowelIndex]}.");
    // }
    
    
    // int totalCharacters
    Console.WriteLine($"Your sentence contains {inputArray.Length} words.");
    Console.WriteLine($"The longest word in your sentence is \"{longestWord}\", it contains {longestWord.Length} letters.");
    Console.WriteLine($"The word with the most vowels is: \"{inputArray[maxVowelIndex]}\". It has {maxVowelValue} vowels.");
    Console.WriteLine($"Total characters in your sentence: {userInput.Length}.");
}



// Running the code:

Console.WriteLine("Task 2-1: ");
ShowHalfDiamond();

Console.WriteLine("Task 2-2: ");
ShowDiamond();

Console.WriteLine("Task 2-3: ");
ShowCross();

Console.WriteLine("Task 2-9: ");
ShowLineStats();

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();