Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "саша")
{
    Console.WriteLine("Ура, это же Санек, как твои дела друг? Я скучал!");
}
else
{
    Console.Write("А ты кто такой? я тебя не знаю! Ну, привет: ");
    Console.WriteLine(username);
}