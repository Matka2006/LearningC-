using System.Text;

namespace Homework
{
    internal class Program
    {
        public string ConcatenateStrings(string StringOne, string StringTwo)
        {
            return StringOne + StringTwo;
        }

        public string GreetUser(string Name, int Age)
        {
            return $"Hello, {Name}!\nYou are {Age} years old.";
        }

        public string StringModificator(string String)
        {
            return $"Длина строки - {String.Length}\n{String.ToUpper()}, {String.ToLower()}";
        }

        public string SubString(string String)
        {
            return String.Substring(0, 5);
        }

        //public string Build(string[] String)
        //{
        //    StringBuilder builder = new StringBuilder();
        //    return builder.Append(String);

        //    foreach (string str in String)
        //    {
        //        return $"{builder.Append(str)} ";
        //    }
        //    return "";
        //}

        public string ReplaceWords(string inputString, string wordToReplace, string replacementWord)
        {
            var a = inputString.Replace(wordToReplace, replacementWord);
            return a;
        }

        static void Main(string[] args)
        {
            Program a = new Program();
            var b = a.ReplaceWords("Matvey", "a", "b");
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}

