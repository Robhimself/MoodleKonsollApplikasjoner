namespace Bossfight;

public class GameCharacter
{
    public string Name { get; }
    public int Health { get; private set; }
    public int Stamina { get; }
    private int Strength { get; }
    private int MinStrength { get; }
    private bool IsStrengthRandom { get; }

    public GameCharacter(string name, int health, int stamina, int strength)
    {
        Name = name;
        Health = health;
        Stamina = stamina;
        Strength = strength;
    }
    public GameCharacter(string name, int health, int stamina, int minStrength, int maxStrength)
    {
        Name = name;
        Health = health;
        Stamina = stamina;
        Strength = maxStrength;
        MinStrength = minStrength;
        IsStrengthRandom = true;
    }

    public void Fight(GameCharacter opponent)
    {
        int damage;
        
        
        if (IsStrengthRandom)
        {
            var rand = new Random();
            damage = rand.Next(MinStrength, Strength + 1);
        }
        else
        {
            damage = Strength;
        }

        opponent.Health -= damage;
        
        if (opponent.Health < 0) opponent.Health = 0;
        
        Console.WriteLine($"{Name} attacked {opponent.Name} and inflicted {damage} damage. {opponent.Name} now has {opponent.Health} health left. ");
    }

    public bool Recharge(int currentStamina)
    {
        var status = $"{currentStamina}/{Stamina}";
        
        if (currentStamina < Stamina)
        {
            Console.WriteLine($"{Name}'s stamina is low ({status}).");
            Console.WriteLine($"{Name} can't fight until stamina is full... *** Stamina +10 ***");
            
            return true;
        }
        else
        {
            Console.WriteLine($"{Name}: Stamina is now full! I can fight again next round!");
            return false;
        }
    }
}