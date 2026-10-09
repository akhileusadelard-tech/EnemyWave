Console.WriteLine("Hello, World!");

string secretCode = "1992";
string attempt = "";

int tries =3;

while(attempt != secretCode && tries > 0)
{
    tries--;
    Console.WriteLine("Enter The Secret Code : ");
    attempt = Console.ReadLine();
    if(attempt!= secretCode)
    {
        Console.WriteLine("Wrong code! Try again...");
        Console.WriteLine($"\n{tries}.attempt(s).remaining");
    }
    else
    {
        Console.WriteLine("The door is unlocked!");
    }
}