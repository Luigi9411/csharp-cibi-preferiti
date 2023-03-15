string[] food = { "Pizza", "Pasta", "Gelato", "Polpette", "Frittura di pesce", "Lenticchie", "Fagioli", "Spiedini", "Salmone", "Pane" };

Console.Write("Lunghezza della classifica:");
Console.WriteLine(food.Length);

for (var i = 0; i < food.Length; i++)
{
    Console.Write(i+1);
    Console.Write(") ");
    Console.WriteLine( food[i]);
};

    Console.WriteLine("Il cibo preferito è:");
    Console.WriteLine(food[0]);

Console.WriteLine("Ultima posizione in classifica:");
Console.WriteLine(food[9]);

Console.WriteLine("Cibi di metà classifica:");
Console.WriteLine(food[5]);
Console.WriteLine(food[6]);


