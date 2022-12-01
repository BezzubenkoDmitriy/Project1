Console.Write("введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Урааа, это же Маша");
}
else
{
    Console.Write ("Привет,");
    Console.Write (username);
}