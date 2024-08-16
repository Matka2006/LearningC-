using System.Collections.Generic;
using System.Collections;
namespace Homework
{
    internal class Program
    {
        private class ListTask
        {
            public string TaskLoop()
            {
                List<string> listString = new List<string>() { };

                listString.Add("fgkugj");
                listString.Add("asdasdasd");
                listString.Add("sdsaddvfa");

                Console.WriteLine("Введите свою строку:");
                var a = Console.ReadLine();
                if (a == "stop")
                {
                    Environment.Exit(0);
                }
                Console.WriteLine(" ");
                listString.Add(a);
                for (int i = 0; i < listString.Count; i++) 
                {
                    Console.WriteLine(listString[i]);
                }
                Console.WriteLine("\nВведите новую строку: ");
                var b = Console.ReadLine();
                if (b == "stop")
                {
                    Environment.Exit(0);
                }
                listString.Insert(1,b);
                return "";
            }
        }

        private class Dictionary
        {
            public string TaskLoop()
            {
                var dictionary = new Dictionary<string, int>();

                Console.WriteLine("Введите количество учеников:");
                var _pupil = Console.ReadLine();

                if (_pupil == "stop")
                {
                    Environment.Exit(0);
                }

                int numPupil = int.Parse(_pupil);

                for (int i=numPupil; i > 0; i--)
                {
                    numPupil--;
                    Console.WriteLine("Введите имя ученика:");
                    var pupilName = Console.ReadLine();

                    if (pupilName == "stop")
                    {
                        Environment.Exit(0);
                    }

                    Console.WriteLine("Введите оценку ученика:");
                    if (Console.ReadLine() == "stop")
                    {
                        Environment.Exit(0);
                    }

                    else
                    {
                        int.TryParse(Console.ReadLine(), out int pupilEstimation);

                        if (pupilEstimation is < 2 or > 5)
                        {
                            Console.WriteLine("Введенные данные не корректны, попробуйте еще раз(значение определяется в диапазоне от 2 до 5):");
                            string pupilEstimationTwo;
                            do
                            {
                                pupilEstimationTwo = Console.ReadLine();

                                if (pupilEstimationTwo == "stop")
                                {
                                    Environment.Exit(0);
                                }

                            } while (int.Parse(pupilEstimationTwo) is < 2 or > 5);

                            pupilEstimation = int.Parse(pupilEstimationTwo);
                            dictionary.Add(pupilName, pupilEstimation);
                        }
                    }

                    
                }
                Console.WriteLine("Введите имя ученика, оценку которого хотите узнать:");
                var name = Console.ReadLine();

                if (name == "stop")
                {
                    Environment.Exit(0);
                }

                else if (dictionary.ContainsKey(name))
                {
                    foreach(var key in dictionary)
                    {
                        if (key.Key == name)
                        {
                            Console.WriteLine(key.Value);
                            break;
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

                        if (nameTwo == "stop")
                        {
                            Environment.Exit(0);
                        }

                    } while (dictionary.ContainsKey(nameTwo));
                }
                return "";
            }
        }

        private class LinkedListTwo
        {
            public class DoublyNode<T>
            {
                public DoublyNode(T data)
                {
                    Data = data;
                }
                public T Data { get; set; }
                public DoublyNode<T> Previous { get; set; }
                public DoublyNode<T> Next { get; set; }
            }

            public class DoublyLinkedList<T> : IEnumerable<T>  // двусвязный список
            {
                DoublyNode<T> head; // головной/первый элемент
                DoublyNode<T> tail; // последний/хвостовой элемент
                int count;  // количество элементов в списке

                // добавление элемента
                public void Add(T data)
                {
                    DoublyNode<T> node = new DoublyNode<T>(data);

                    if (head == null)
                        head = node;
                    else
                    {
                        tail.Next = node;
                        node.Previous = tail;
                    }
                    tail = node;
                    count++;
                }
                public void AddFirst(T data)
                {
                    DoublyNode<T> node = new DoublyNode<T>(data);
                    DoublyNode<T> temp = head;
                    node.Next = temp;
                    head = node;
                    if (count == 0)
                        tail = head;
                    else
                        temp.Previous = node;
                    count++;
                }
                // удаление
                public bool Remove(T data)
                {
                    DoublyNode<T> current = head;

                    // поиск удаляемого узла
                    while (current != null)
                    {
                        if (current.Data.Equals(data))
                        {
                            break;
                        }
                        current = current.Next;
                    }
                    if (current != null)
                    {
                        // если узел не последний
                        if (current.Next != null)
                        {
                            current.Next.Previous = current.Previous;
                        }
                        else
                        {
                            // если последний, переустанавливаем tail
                            tail = current.Previous;
                        }

                        // если узел не первый
                        if (current.Previous != null)
                        {
                            current.Previous.Next = current.Next;
                        }
                        else
                        {
                            // если первый, переустанавливаем head
                            head = current.Next;
                        }
                        count--;
                        return true;
                    }
                    return false;
                }

                public int Count { get { return count; } }
                public bool IsEmpty { get { return count == 0; } }

                public void Clear()
                {
                    head = null;
                    tail = null;
                    count = 0;
                }

                public bool Contains(T data)
                {
                    DoublyNode<T> current = head;
                    while (current != null)
                    {
                        if (current.Data.Equals(data))
                            return true;
                        current = current.Next;
                    }
                    return false;
                }

                IEnumerator IEnumerable.GetEnumerator()
                {
                    return ((IEnumerable)this).GetEnumerator();
                }

                IEnumerator<T> IEnumerable<T>.GetEnumerator()
                {
                    DoublyNode<T> current = head;
                    while (current != null)
                    {
                        yield return current.Data;
                        current = current.Next;
                    }
                }

                public IEnumerable<T> BackEnumerator()
                {
                    DoublyNode<T> current = tail;
                    while (current != null)
                    {
                        yield return current.Data;
                        current = current.Previous;
                    }
                }
            }

            public void TaskLoop()
            {
                DoublyLinkedList<string> linkedList = new DoublyLinkedList<string>();

                Console.WriteLine("Напишите из скольки элементов хотите составить двусвязанный списко(от 3 до 6):");
                var num = Console.ReadLine();

                if (num == "stop")
                {
                    Environment.Exit(0);
                }

                else
                {
                    Console.WriteLine("Вводите значение одно за другим");
                    int numElement = int.Parse(num);
                    for (int i = numElement; i > 0; i--)
                    {
                        var a = Console.ReadLine();
                        if (a == "stop")
                        {
                            Environment.Exit(0);
                        }

                        else
                        {
                            linkedList.Add(a);
                        }
                    }

                    foreach(var item in linkedList)
                    {
                        Console.WriteLine(item);
                    }

                    foreach(var item in linkedList.BackEnumerator())
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }

        static void Main(string[] argv)
        {
            ListTask _list = new ListTask();
            Dictionary _dic = new Dictionary();
            LinkedListTwo _linked = new LinkedListTwo();

            Console.WriteLine("Введите номер задачи:");
            var numTask = Console.ReadLine();

            switch (numTask)
            {
                case "stop":
                    Environment.Exit(0);
                    break;
                case "1":
                    _list.TaskLoop();
                    break;
                case "2":
                    _dic.TaskLoop();
                    break;
                case "3":
                    _linked.TaskLoop();
                    break;
            }
        }
    }
}

