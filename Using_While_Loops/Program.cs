bool connected = true;
int number = 0;

while (number < 5)
{
    Console.Clear();
    Console.WriteLine("number = " + number);
    for (int i = 0; i < 5000; i++)
    {
        Console.WriteLine("i = " + i);
    }
    if (number == 3)
        break;
    number++;
}

Console.WriteLine("All done!");