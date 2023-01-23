namespace PensumSjekkUke3;

public class Pet
{
    public string Name { get; private set; }
    public int Age { get; }
    public string Color { get; }

    public static int Counter;

    public Pet(string name, int age, string color)
    {
        Name = name;
        Age = age;
        Color = color;
        Counter++;
    }

    public void Feed(string? food)
    {
        string reply;
        if (food.Length < 2)
        {
            reply = $"{Name}: \"That's not real food!\"";
            Console.WriteLine(reply);
        }
        else
        {
            reply = $"{Name}: \"Mmm... {food}. Thank you, I was very hungry.\"";
            Console.WriteLine(reply);
        }
    }
    public void Feed(string? food, bool favorite)
    {
        string reply;
        if (!favorite)
        {
            Feed(food);
            return;
        }
            reply = $"{Name}: \"Mmm... {food}. That's my favorite! How did you know? Thank you very much!\"";
            Console.WriteLine(reply);
    }
}
