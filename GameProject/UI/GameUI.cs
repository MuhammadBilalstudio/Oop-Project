using System;

private void ShowInstructions()
{
    Console.Clear();

    Console.WriteLine("=== HOW TO PLAY ===");
    Console.WriteLine();
    Console.WriteLine("1. Choose Start Game from the main menu.");
    Console.WriteLine("2. Enter your player name.");
    Console.WriteLine("3. Choose Attack to damage the monster.");
    Console.WriteLine("4. Use a healing potion to restore your health.");
    Console.WriteLine("5. You win by defeating all the monsters.");
    Console.WriteLine("6. If your health reaches zero, you lose.");
    Console.WriteLine("7. Defeating monsters gives you points.");
    Console.WriteLine("8. Winning the game gives you bonus points based on");
    Console.WriteLine("   your remaining health and unused healing potions.");

    Pause();
}