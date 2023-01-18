Random random = new Random();

Console.WriteLine("First argument: " + args[0]);
Console.WriteLine("Second argument: " + args[1]);


if (!IsValid(args))
{
    ShowHelpText();
    return;
}

// Console.WriteLine(helpText);
//         
// // 1. Hvis programmet kalles uten args, skal det vise en melding. 
// if (args.Length != 2)
// {
//     Console.WriteLine("Du har ikke riktig parametere.");
//     Console.WriteLine(helpText);
// }

// 2. Hvis args inneholder akkurat 2 parametre skal disse sjekkes.
// Første inneholder kun tall. Og har den noe annet enn tall skal meldingen vises på nytt. 

// foreach (var c in args[0])
// {
//     if (!char.IsDigit(c))
//     {
//         Console.WriteLine("Du har ikke riktig parametere.");
//         Console.WriteLine(helpText);
//     }
//     Console.WriteLine("Digit check: "+c);
// }

// 3. Sjekk den andre parameteren.
// Den skal ikke inneholde noe annet enn l, L, d og s. Vis samme melding hvis denne inneholder noe annet. 

// var allowedChars = "lLds";
// foreach (var c in args[1])
// {
//     if (!allowedChars.Contains(c.ToString()))
//     {
//         Console.WriteLine(helpText);
//     }
//
//     Console.WriteLine("Char check: "+c);
// }

// 4. Samle alle disse punktene over i en egen metode IsValid() som returner true/false. 
// Lag også en egen metode ShowHelpText() som viser den nevnte meldingen. 

static bool IsValid(string[] arg)
{
    var allowedChars = "lLds";

    // 1. Hvis programmet kalles uten args, skal det vise en melding. 
    if (arg.Length != 2) return false;

    // 2. Hvis args inneholder akkurat 2 parametre skal disse sjekkes.
    foreach (var c in arg[0])
    {
        if (!char.IsDigit(c)) return false;
        Console.WriteLine("Digit check: " + c);
    }

    // 3. Sjekk den andre parameteren.
    foreach (var c in arg[1])
    {
        if (!allowedChars.Contains(c.ToString())) return false;

        Console.WriteLine("Char check: " + c);
    }

    return true;
}

static string ShowHelpText()
{
    const string helpText = @"PasswordGenerator  
Options:
    - l = lower case letter
    - L = upper case letter
    - d = digit
    - s = special character !""#¤%&/(){}[]

Example: PasswordGenerator 14 lLssdd
    Min. 1 lower case
    Min. 1 upper case
    Min. 2 special characters
    Min. 2 digits
";
    return helpText;
}

var pattern = args[1];
var passLength = Convert.ToInt32(args[0]);

var lowerLPad = 'l';
var upperLPad = 'L';
var dPad = 'd';
var sPad = 's';

var testOutput = pattern.PadRight(passLength, lowerLPad);

// while løkke.
while (testOutput.Length > 0)
{
    var last = testOutput.Remove(0, testOutput.Length - 1);
    Console.WriteLine("Letter checked before being removed: " + last);
    if (last == "l")
    {
        var randomLowL = WriteRandomLowerCaseLetter(random);
        Console.WriteLine("Expected: lower letter, actual: " + randomLowL);
    }

    if (last == "L")
    {
        var randomLowL = WriteRandomUpperCaseLetter(random);
        Console.WriteLine("Expected: upper letter, actual: " + randomLowL);
    }

    if (last == "d")
    {
        var randomLowL = WriteRandomDigit(random);
        Console.WriteLine("Expected: digit, actual: " + randomLowL);
    }

    if (last == "s")
    {
        var randomLowL = WriteRandomSpecialCharacter(random);
        Console.WriteLine("Expected: !, actual: " + randomLowL);
    }


    Console.WriteLine("Current word: " + testOutput);
    testOutput = testOutput.Remove(testOutput.Length - 1);
}


Console.WriteLine("Test of output string: " + testOutput);

static string WriteRandomLowerCaseLetter(Random random)
{
    const string letters = "abcdefghijklmnopqrstuvwxyz";
    var randomIndex = random.Next(0, letters.Length - 1);
    return letters.Remove(randomIndex, 1);
}

static string WriteRandomUpperCaseLetter(Random random)
{
    const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    var randomIndex = random.Next(0, letters.Length - 1);
    return letters.Remove(randomIndex, 1);
}

static string WriteRandomDigit(Random random, int min = 0, int max = 9)
{
    var randomDigit = random.Next(min, max);
    return randomDigit.ToString();
}

static string WriteRandomSpecialCharacter(Random random)
{
    const string list = @"!""#¤%&/(){}[]";
    var randomIndex = random.Next(0, list.Length - 1);
    var special = list.Remove(randomIndex, 1);
    return special;
}


Console.WriteLine("testing Random: " + WriteRandomDigit(random));
Console.WriteLine("testing Random: " + WriteRandomDigit(random));
Console.WriteLine("testing Random: " + WriteRandomDigit(random));
Console.WriteLine("testing Random: " + WriteRandomDigit(random));
Console.WriteLine("testing Random: " + WriteRandomDigit(random));