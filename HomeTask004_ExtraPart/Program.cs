using System;
using System.Threading;

namespace HomeTask004_ExtraPart
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isUserDone = false;
            Console.WriteLine("Добро пожаловать в Мега-убер-супер-экстара-лимитед-эдишн словарь. Издание на 10 слов.");
            Console.WriteLine("Это работает так. Введите слово о погоде и я покажу его вам... (Если вы не знакомы с нашима убер Справочником введите help и я выведу все доступные слова для перевода) \n" );

            while (!isUserDone)
            {
                string[] wordsRus = new string[] { "холодно", "тепло", "дождь", "ветер", "слякоть", "град", "снег", "температура", "облачно", "ветрено" };
                string[] wordsEng = new string[] { "cold", "warm", "rain", "wind", "slush", "hail", "snow", "temperature", "cloudy", "windy" };
                Console.Clear();
                Console.WriteLine("Введите слово для перевода или help для вывода всех доступных слов...");
                string userWord = Console.ReadLine();

                // implement user Choise logic
                switch (userWord) 
                {
                    case "холодно":
                        Console.WriteLine($"Перевод слова {userWord} будет {wordsEng[0]} ");
                        break;
                    case "тепло":
                        Console.WriteLine($"Перевод слова {userWord} будет {wordsEng[1]} ");
                        break;
                    case "дождь":
                        Console.WriteLine($"Перевод слова {userWord} будет {wordsEng[2]} ");
                        break;
                    case "ветер":
                        Console.WriteLine($"Перевод слова {userWord} будет {wordsEng[3]} ");
                        break;
                    case "слякоть":
                        Console.WriteLine($"Перевод слова {userWord} будет {wordsEng[4]} ");
                        break;
                    case "град":
                        Console.WriteLine($"Перевод слова {userWord} будет {wordsEng[5]} ");
                        break;
                    case "снег":
                        Console.WriteLine($"Перевод слова {userWord} будет {wordsEng[6]} ");
                        break;
                    case "температура":
                        Console.WriteLine($"Перевод слова {userWord} будет {wordsEng[7]} ");
                        break;
                    case "облачно":
                        Console.WriteLine($"Перевод слова {userWord} будет {wordsEng[8]} ");
                        break;
                    case "ветрено":
                        Console.WriteLine($"Перевод слова {userWord} будет {wordsEng[9]} ");
                        break;
                    case "help":
                        Console.WriteLine("Список доступных слов -- ");
                        Thread.Sleep(200);
                        for (int i = 0; i < wordsRus.Length; i++) 
                        {
                            Console.WriteLine(wordsRus[i]);
                        }
                        break;
                    default:
                        Console.WriteLine("Неправильный ввод или такое слово отсутсвует в нашем словаре. Попробуйте ввести help для просмотра доступных слов");
                        break;
                }
                Console.WriteLine("\n Cпасибо за пользование нашим убер переводчиком. Надеюсь вам зашло...");
                Console.ReadKey();
            }
        }
    }
}
