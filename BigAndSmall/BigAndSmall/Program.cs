// See https://aka.ms/new-console-template for more information
using BigAndSmall;

Console.WriteLine("Вiтаю в ХIЛО.");
Console.WriteLine($"Випадкове число може бути вiв 1 до {HiloGame.MAXIMUM}.");
HiloGame.Hint();
while (HiloGame.GetPot() > 0)
{
    Console.WriteLine("Натисни H для вибору бiльшого числа, L для меншого, W щоб купити пiдказку,");
    Console.WriteLine($"або будь яку клавiшу для виходу з {HiloGame.GetPot()} гривнями в гаманцi");

    char key = Console.ReadKey(true).KeyChar;
    if (key == 'h' || key == 'H')
    {
        Console.Clear();
        HiloGame.Guess(true);
    }
    else if (key == 'l' || key == 'L')
    {
        Console.Clear();
        HiloGame.Guess(false);
    }
    else if (key == 'w' || key == 'W')
    {
        Console.Clear();
        HiloGame.Hint();
    }
    else return;
}
Console.Clear();
Console.WriteLine("ТИ ПРОГРАВ! ДО ЗУСТРIЧI!");