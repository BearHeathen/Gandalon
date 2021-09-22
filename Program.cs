// Welcome screen
Console.WriteLine("\n___________________GANDOLON ARISES___________________\n");
Console.WriteLine("Be thou wolecome, oh my budding programmer!");
Console.WriteLine("If thou wouldst be so kind as to draw one of the following cards:\n");
Console.WriteLine(" -----   -----   -----   -----   -----");
Console.WriteLine("|     | |     | |     | |     | |     |");
Console.WriteLine("|  1  | |  2  | |  3  | |  4  | |  5  |");
Console.WriteLine("|     | |     | |     | |     | |     |");
Console.WriteLine(" -----   -----   -----   -----   -----\n");
Console.WriteLine("Enter a number from 1 to 5 that thou mayest choose and then press [ENTER].");

// Get player's answer. Convert str to int.
var userInput = Console.ReadLine();
int enteredNumber = Convert.ToInt32(userInput);

//Gandolon's Answer #1
Console.WriteLine("Thou hast chosen card number " + enteredNumber);

//Displaying the card to user
// ♥♠♣♦
Console.WriteLine("And this be thy card; watch it well!");
if (enteredNumber == 1)
{
    Console.WriteLine(" ----- ");
    Console.WriteLine("|♥    |");
    Console.WriteLine("|  A  |");
    Console.WriteLine("|    ♥|");
    Console.WriteLine(" ----- ");

}

else if (enteredNumber == 2)
{
    Console.WriteLine(" ----- ");
    Console.WriteLine("|♠    |");
    Console.WriteLine("|  J  |");
    Console.WriteLine("|    ♠|");
    Console.WriteLine(" ----- ");
}

else if (enteredNumber == 3)
{
    Console.WriteLine(" ----- ");
    Console.WriteLine("|♣    |");
    Console.WriteLine("|  K  |");
    Console.WriteLine("|    ♣|");
    Console.WriteLine(" ----- ");
}

else if (enteredNumber == 4)
{
    Console.WriteLine(" ----- ");
    Console.WriteLine("|♦    |");
    Console.WriteLine("|  A  |");
    Console.WriteLine("|    ♦|");
    Console.WriteLine(" ----- ");
}

else if (enteredNumber == 5)
{
    Console.WriteLine(" ----- ");
    Console.WriteLine("|♣    |");
    Console.WriteLine("|  7  |");
    Console.WriteLine("|    ♣|");
    Console.WriteLine(" ----- ");
}

else
{
    Console.WriteLine("Ha ha ha! Thou art unable to fool me! Here, then, is thy card!");
    Console.WriteLine(" ----- ");
    Console.WriteLine("|♠    |");
    Console.WriteLine("|  Q  |");
    Console.WriteLine("|    ♠|");
    Console.WriteLine(" ----- ");
}

// Let the user memorize the card
Thread.Sleep(1000);

// Wait for user input
Console.WriteLine("Hit [ENTER], when thou art prepared to behold the puissance of mine Art!");
Console.ReadLine();

// Gandolon Answer # 2
Console.WriteLine("Now, I shall divine the card which thou hast drawn!");
Thread.Sleep(500);
Console.WriteLine("Thou shalt open thy thoughts unto me, that I may discern them well!");

// Gandolon's thinking
for (var i = 0; i < 4; i++)
{
    Thread.Sleep(500 * i);
    Console.WriteLine("Hmm..");
}

// Tension for the user.
Thread.Sleep(1000);
Console.WriteLine("EUREKA!");
Thread.Sleep(1000);

// Gandolon reveals the drawn card.
Console.WriteLine("I have divined that thy card was: ");
if (enteredNumber == 1)
{
    Console.WriteLine(" ----- ");
    Console.WriteLine("|♥    |");
    Console.WriteLine("|  A  |");
    Console.WriteLine("|    ♥|");
    Console.WriteLine(" ----- ");

}

else if (enteredNumber == 2)
{
    Console.WriteLine(" ----- ");
    Console.WriteLine("|♠    |");
    Console.WriteLine("|  J  |");
    Console.WriteLine("|    ♠|");
    Console.WriteLine(" ----- ");
}

else if (enteredNumber == 3)
{
    Console.WriteLine(" ----- ");
    Console.WriteLine("|♣    |");
    Console.WriteLine("|  K  |");
    Console.WriteLine("|    ♣|");
    Console.WriteLine(" ----- ");
}

else if (enteredNumber == 4)
{
    Console.WriteLine(" ----- ");
    Console.WriteLine("|♦    |");
    Console.WriteLine("|  A  |");
    Console.WriteLine("|    ♦|");
    Console.WriteLine(" ----- ");
}

else if (enteredNumber == 5)
{
    Console.WriteLine(" ----- ");
    Console.WriteLine("|♣    |");
    Console.WriteLine("|  7  |");
    Console.WriteLine("|    ♣|");
    Console.WriteLine(" ----- ");
}

else
{
    Console.WriteLine(" ----- ");
    Console.WriteLine("|♦    |");
    Console.WriteLine("|  Q  |");
    Console.WriteLine("|    ♦|");
    Console.WriteLine(" ----- ");
}

// Let the user decide whether to be honest with Gandolon and await his answer
Console.WriteLine("Is this verily so? Have I divined thy card correctly? [Y]ea or [N]ay");
string userAnswer = Console.ReadLine().Substring(0, 1).ToUpper();

if (userAnswer == "Y")
{
    Console.WriteLine("\nI am Gandolon, mighty Sorceror!\n");
}

else if (userAnswer == "N")
{
    Console.WriteLine("\nWHAT? It cannot be! Thou art a vile dissembler and a rogue! \nGandolon never fails to divine the correct answer!\nBegone before I transmogrify thee into some fell beast!\n");
}

else
{
    Console.WriteLine("\nThy cunning deception is futile. Thou canst nay fool the mighty Gandolon, for I know this was the card thou hast chosen, knave!\nBegone before I transmogrify thee into some fell beast!\n");
}
