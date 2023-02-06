

using Bossfight;

Console.WriteLine("Hello, World!");
Console.WriteLine("This is BossFight!");
Console.WriteLine();

var hero = new GameCharacter("Hero",100, 40, 20);
var boss = new GameCharacter("Boss",400, 10, 0, 30);

var currentHeroStamina = hero.Stamina;
var currentBossStamina = boss.Stamina;
var heroIsRecharging = false;
var bossIsRecharging = false;

while (hero.Health > 0 && boss.Health > 0)
{
    if (heroIsRecharging == false)
    {
        if (currentHeroStamina <= 0)
        {
            heroIsRecharging = hero.Recharge(currentHeroStamina);
            currentHeroStamina += 10;
        }
        else
        {
            hero.Fight(boss);
            currentHeroStamina -= 10;
        }
    }
    else
    {
        heroIsRecharging = hero.Recharge(currentHeroStamina);
        currentHeroStamina += 10;
    }

    if (bossIsRecharging == false)
    {
        if (currentBossStamina <= 0)
        {
            bossIsRecharging = boss.Recharge(currentBossStamina);
            currentBossStamina += 10;
        }
        else
        {
            boss.Fight(hero);
            currentBossStamina -= 10;
        }
    }
    else
    {
        bossIsRecharging = boss.Recharge(currentBossStamina);
        currentBossStamina += 10;
    } 
}

Console.WriteLine(hero.Health <= 0 // Resharper Magic: refactored from if-else statement. 
    ? $"{boss.Name} won! {hero.Name} has fallen..."
    : $"{hero.Name} has defeated {boss.Name}! {hero.Name} is our savior! Long live {hero.Name}!");

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();