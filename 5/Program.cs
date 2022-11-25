Console.Write("Введите ваше имя:");
string username = Console.ReadLine ();

if (username.ToLower() == "толик")
{
    Console.WriteLine ("Ура!Ура!Ура! Это " + username);
}
else
{
    Console.WriteLine("Привет " + username);
}
