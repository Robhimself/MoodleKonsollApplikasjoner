using System.Text;

Random random = new Random();

var passLength = Convert.ToInt32(args[0]);
var pattern = args[1];
var padding = 'l';
var userInput = pattern.PadRight(passLength, padding);
StringBuilder newPassword = new StringBuilder();

if (!IsValid(args))
{
    ShowHelpText();
    return;
}

Console.WriteLine("First argument - password length: " + args[0]);
Console.WriteLine("Second argument - character criteria: " + args[1]);

static bool IsValid(string[] arg)
{
    var allowedChars = "lLds";

    if (arg.Length != 2) return false;

    foreach (var c in arg[0])
    {
        if (!char.IsDigit(c)) return false;
    }

    foreach (var c in arg[1])
    {
        if (!allowedChars.Contains(c.ToString())) return false;
    }
    return true;
}

static string ShowHelpText()
{
    const string helpText = @"PasswordGenerator by Robert L. (2023) 
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

// Getting our random characters before shuffling to a randomized password

while (userInput.Length > 0)
{
    var rnd = random.Next(userInput.Length);
    var last = userInput.Substring(rnd, 1);
    userInput = userInput.Remove(rnd, 1);
    
    if (last == "l")
    {
        newPassword.Append(WriteRandomLowerCaseLetter(random));
    }
    
    if (last == "L")
    {
        newPassword.Append(WriteRandomUpperCaseLetter(random));
    }

    if (last == "d")
    {
        newPassword.Append(WriteRandomDigit(random));
    }

    if (last == "s")
    {
        newPassword.Append(WriteRandomSpecialCharacter(random));
    }
}

static int WriteRandomDigit(Random random, int max = 10)
{
    var randomDigit = random.Next(max);
    return randomDigit;
}

static char WriteRandomLowerCaseLetter(Random random)
{
    const string lowLetters = "abcdefghijklmnopqrstuvwxyz";
    var randomIndex = random.Next(lowLetters.Length);
    return lowLetters[randomIndex];
}

static char WriteRandomUpperCaseLetter(Random random)
{
    const string upperLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    var randomIndex = random.Next(upperLetters.Length);
    return upperLetters[randomIndex];
}

static char WriteRandomSpecialCharacter(Random random)
{
    const string list = @"!""#¤%&/(){}[]";
    var randomIndex = random.Next(list.Length);
    return list[randomIndex];
}

var output = newPassword.ToString();
Console.WriteLine($"New Password: {output}");