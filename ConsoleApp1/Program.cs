// See https://aka.ms/new-console-template for more information

// C# basics part 2 
// task 1 control flow

int currentHour = DateTime.Now.Hour;

if (currentHour >= 11 && currentHour <= 15)
{
    Console.WriteLine($"Time for lunch!");
}
else
{
    Console.WriteLine("Not time for lunch");
}

// task 2 print 1 -> 10 using loop
Console.WriteLine("print from 1 to 10");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

// Bonus
Console.WriteLine("countdown from 5 to 1");

int countdown = 5;
while (countdown >= 1)
{
    Console.WriteLine(countdown);
    countdown--;
}
