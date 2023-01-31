
char[] alphabet =
{
    'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
    'W', 'X', 'Y', 'Z'
};
char[] cipherAlphabet =
{
    'W', 'E', 'Y', 'I', 'V', 'X', 'B', 'Z', 'M', 'T', 'S', 'D', 'O', 'R', 'G', 'J', 'A', 'N', 'K', 'U', 'C', 'L',
    'F', 'Q', 'H', 'P'
};

// 3-3 Write a bool function that checks in the passed array with num of elements is sorted. 

int[] taskOneArray1 = { 1, 2, 3, 4, 5 };
int[] taskOneArray2 = { 9, 2, 1, 4, 5, 11 };
int[] taskOneArray3 = { 1 };
var taskOneNumber1 = taskOneArray1.Length;
var taskOneNumber2 = taskOneArray2.Length;
var taskOneNumber3 = taskOneArray3.Length;

bool IsArraySorted(int[] arr, int elements )
{
    if (elements is 0 or 1) return true;
    
    for (var i = 1; i < elements-1; i++)
    {
        if (arr[i] < arr[i - 1]) return false;
    }

    return true;
}

Console.WriteLine(IsArraySorted(taskOneArray1, taskOneNumber1)
    ? "TaskOneArray1 is true!"
    : "TaskOneArray1 is false...");

Console.WriteLine(IsArraySorted(taskOneArray2, taskOneNumber2)
    ? "TaskOneArray2 is true!"
    : "TaskOneArray2 is false...");

Console.WriteLine(IsArraySorted(taskOneArray3, taskOneNumber3)
    ? "TaskOneArray3 is true!"
    : "TaskOneArray3 is false...");
    
    
    
// 3-4 Write a program that uses ciphertext. And bonus Caesar Cipher for myself :D 

var testString = "Det var en gang en Robert som studerte.";
void GetCipherText(string input)
{
    input = input.ToUpper();

    for (var i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ')
        {
            Console.Write(" ");
        }
        else
        {
            for (var j = 0; j < alphabet.Length - 1; j++)
            {
                if (alphabet[j] == input[i])
                {
                    Console.Write(cipherAlphabet[j]);
                }
            }
        }
    }
    Console.WriteLine();
}
GetCipherText(testString);


// 3-5 Decode the message from 3-4. 

var codedTestString = "IVU LWN VR BWRB VR NGEVNU KGO KUCIVNUV"; // output from GetCipherText(testString).
void DecodeCipherText(string input)
{
    input = input.ToUpper();

    for (var i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ')
        {
            Console.Write(" ");
        }
        else
        {
            for (var j = 0; j < alphabet.Length - 1; j++)
            {
                if (cipherAlphabet[j] == input[i])
                {
                    Console.Write(alphabet[j]);
                }
            }
        }
    }
    Console.WriteLine();
}

DecodeCipherText(codedTestString);


// Make the cipher more random

char[] GenerateRandomCipherArray()
{
    var rand = new Random();
    var generatedArray = new char[alphabet.Length];

    foreach (var character in alphabet)
    {
        var randomIndex = rand.Next(alphabet.Length);
        
        while (generatedArray[randomIndex] != '\0')
        {
            randomIndex = rand.Next(alphabet.Length);
        }
        
        generatedArray[randomIndex] = character;
    }
    
    return generatedArray;
}

var randomArray =  GenerateRandomCipherArray();

var index = 1;
 foreach (var letter in randomArray)
 {
     Console.WriteLine($"{index}: {letter}");
     index++;
 }