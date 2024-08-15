namespace Homework
{
    internal class Program
    {
        private class ListTask
        {
            public string String()
            {
                List<string> listString = new List<string>() { };
                listString.Add("fgkugj");
                listString.Add("asdasdasd");
                listString.Add("sdsaddvfa");
                Console.WriteLine("Введите свою строку:");
                var a = Console.ReadLine();
                Console.WriteLine(" ");
                listString.Add(a);
                for (int i = 0; i < listString.Count; i++) 
                {
                    Console.WriteLine(listString[i]);
                }
                Console.WriteLine("Введите еще раз свою строку: ");
                var b = Console.ReadLine();
                listString.Insert(1,b);
                return "";
            }
        }

        private class Dictionary
        {
            public string Estimation()
            {
                var dictionary = new Dictionary<string, int>();
                Console.WriteLine("Введите количество учеников:");
                var _pupil = Console.ReadLine();
                int numPupil = int.Parse(_pupil);
                for (int i=numPupil; i > 0; i--)
                {
                    numPupil--;
                    Console.WriteLine("Введите имя ученика:");
                    var pupilName = Console.ReadLine();
                    Console.WriteLine("Введите оценку ученика:");
                    int.TryParse(Console.ReadLine(), out int pupilEstimation);
                    if (pupilEstimation is <2 or > 5)
                    {
                        Console.WriteLine("Введенные данные не корректны, попробуйте еще раз:");
                        string pupilEstimationTwo;
                        do
                        {
                            pupilEstimationTwo = Console.ReadLine();
                        } while (int.Parse(pupilEstimationTwo) is < 2 or > 5);
                        pupilEstimation = int.Parse(pupilEstimationTwo);
                    }
                    dictionary.Add(pupilName, pupilEstimation);
                }
                Console.WriteLine(" ");
                Console.WriteLine("Введите имя ученика, оценку которого хотите узнать:");
                var name = Console.ReadLine();
                if (dictionary.ContainsKey(name))
                {
                    foreach(var key in dictionary)
                    {
                        if (key.Key == name)
                        {
                            Console.WriteLine(key.Value);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Введенные данные не корректны, попробуйте еще раз:");
                    string nameTwo;
                    do
                    {
                        nameTwo = Console.ReadLine();
                    } while (dictionary.ContainsKey(nameTwo));
                }
                return "";
            }
        }


        static void Main(string[] argv)
        {
            Dictionary dic = new Dictionary();
            var b = dic.Estimation();
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}

