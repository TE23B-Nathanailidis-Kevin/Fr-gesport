int points = 0;
Console.WriteLine(" Tjena Tjena detta är Alexandros frågesport om olika karaktärer!(Press Enter)");
Console.ReadLine();
Console.WriteLine("Om du vinner så får du ett pris!(Press Enter)");
Console.ReadLine();


Console.WriteLine("1: Vad heter Alfons i efternamn?");
Console.WriteLine("a) Åsberg  b) Åberg c) Weinerbruds");
string answer1 = Console.ReadLine();
if (answer1 == "b")
{
  points++;
  Console.WriteLine("BRA nu kan du få Tzatziki!");
}
else
{
  Console.WriteLine("Inge tzatziki till dig.");
}


Console.WriteLine("2: Vad heter Spiderman?");
Console.WriteLine("a) Charmander  b) Jonas  c) Peter Parker");
string answer2 = Console.ReadLine();
if (answer2 == "c")
{
  points++;
  Console.WriteLine("Bra, nu kan du få Grekiska oliver!");
}
else
{
  Console.WriteLine("Fel svar kompis, inga oliver för dig.");
}


Console.WriteLine("3: Vad heter Dr.doom");
Console.WriteLine("a) Victor von doom  b) Vector Kachigga doom  c) Victooorrrrr");
string answer3 = Console.ReadLine();
if (answer3 == "a")
{
  points++;
  Console.WriteLine("Mycket bra kompis");
}
else
{
  Console.WriteLine("Du är sämst");
}


Console.WriteLine($"Du fick {points} poäng.");
if (points == 0)
{
  Console.WriteLine("Du får inge Gyros.");
}
else if (points < 3)
{
  Console.WriteLine("Helt ok ändå, du kunde lite men tyvärr inge gyros för dig.");
}
else 
{
  Console.WriteLine("Grattis! Du hade alla rätt! Nu kan du få gyros.");
}

Console.WriteLine("Tryck på valfri tangent för att avsluta.");
Console.ReadKey();