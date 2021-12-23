using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

namespace Module_13
{
    class Program
    {
        static void Main(string[] args)
        {

            ShowQueueWorking();

            //ShowStackWorking();

            // CntUniqSymbolsInText();
            // var stopWatch = Stopwatch.StartNew();
            //  FillPhoneBook();
            // // FillPhoneBookBySortedDictionary();
            //  Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);
            // Console.WriteLine(Environment.NewLine);
            // FillPhoneBookBySortedDictionary();

            //var months = new List<string>()
            //{
            //   "Jan", "Feb", "Mar", "Apr", "May"
            //};

            //var missing = new ArrayList()
            //{
            //   1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            //};

            //AddElemToList(months,missing);
            //Contact contact = new Contact(name:"Ruslan",phoneNumber:79375257001,email:"lar@yandex.ru");
            //List<Contact> phoneBook = new List<Contact>()
            //{
            //    new Contact(name:"Zuslan1",phoneNumber:79375257001,email:"lar@yandex.ru"),
            //    new Contact(name:"Mlmir",phoneNumber:79375251001,email:"ed@yandex.ru"),
            //    new Contact(name:"Aara",phoneNumber:79375557001,email:"zar@yandex.ru")
            //};

            //AddUnique(contact, phoneBook);

            //ArrayList arrList = new ArrayList()
            //{
            //    1,2,"H",3,4,5,"E","L",6,7,"L",8,9,"O"
            //};

            //var list =  ArrayListOperation(arrList);

            //foreach (var elem in list)
            //{
            //    Console.WriteLine(elem);
            //}
            //uneducatedListWorkShow();
            //Console.WriteLine("Введите путь к текстовому файлу");
            //string path = @"C:\Users\pc\Downloads\cdev_Text.txt";
            //long wordsCnt = 0;
            //char[] sepChars = { ' ', '\n', '\r' };
            //if (File.Exists(path))
            //{
            //    try
            //    {
            //        var text = File.ReadAllText(path);
            //        var words = text.Split(sepChars, StringSplitOptions.RemoveEmptyEntries);
            //        wordsCnt = words.Length;
            //        //using (StreamReader sr = File.OpenText(path))
            //        //{
            //        //    string str = string.Empty;
            //        //    var temp = new string[] {""};

            //        //    //while ((str = sr.ReadLine()) != null)
            //        //    //{
            //        //    //    str = str.Trim();
            //        //    //    for(int i = 0; i < str.Length; i++)
            //        //    //    {
            //        //    //        temp = str.Split(sepChars,StringSplitOptions.RemoveEmptyEntries);
            //        //    //        wordsCnt += temp.Length;
            //        //    //    }
            //        //    //}
            //        //}

            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Файл по заданному пути не найден");
            //}
            //Console.WriteLine($"Количество слов в книге: {wordsCnt}");
        }

        private static bool checkArray(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1]) return true;
            }

            return false;
        }

        private static void uneducatedListWorkShow()
        {
            var months = new[]
            {
                "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };

            var numbers = new[]
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10,
                11,
                12
            };

            var arrList = new ArrayList();
            for (int i = 0; i < months.Length; i++)
            {
                arrList.Add(months[i]);
                arrList.Add(numbers[i]);
            }

            foreach (var elem in arrList)
            {
                Console.WriteLine(elem);
            }
        }

        private static ArrayList ArrayListOperation(ArrayList arrList)
        {
            int sum = 0;
            StringBuilder text = new StringBuilder();
            foreach (var elem in arrList)
            {
                if (elem is int)
                {
                    sum += (int)elem;
                }
                else if (elem is string)
                {
                    text.Append(elem);
                }
            }
            var list = new ArrayList();
            list.Add(sum);
            list.Add(text);
            return list;
        }

        private static void AddUnique(Contact contact, List<Contact> phoneBook)
        {
            for (int i = 0; i < phoneBook.Count; i++)
            {
                if(phoneBook[i].Name == contact.Name)
                {
                    return;
                }     
            }

            phoneBook.Add(contact);

            foreach (var elem in phoneBook)
            {
                Console.WriteLine(elem.Name + " " + elem.PhoneNumber);
            }

            phoneBook.Sort();
            foreach (var elem in phoneBook)
            {
                Console.WriteLine(elem.Name + " " + elem.PhoneNumber);
            }

        }

        private static void AddElemToList(List<string> months, ArrayList missing)
        {
            var misArray = new string[7];
            missing.GetRange(4, 7).CopyTo(misArray);
            months.AddRange(misArray);

            foreach (var elem in months)
            {
                Console.WriteLine(elem);
            }
        }

        private static void CntUniqSymbolsInText ()
        {
            char[] sepChars = {' '};
            var text = "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";
            while (true)
            {
                Console.WriteLine("Введите текст:");
                text = Console.ReadLine();
                var temp = text.Trim().ToCharArray();
                HashSet<char> unqElem = new HashSet<char>();
                unqElem.UnionWith(temp);
                foreach (var elem in unqElem)
                {
                    Console.WriteLine(elem);
                }

                unqElem.ExceptWith(sepChars);
                Console.WriteLine("Количество уникальных элементов в коллекции:" + unqElem.Count);
                var numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                Console.WriteLine("Цирфы в коллекции: " + (unqElem.Overlaps(numbers) ? "Есть" : "Нет"));
            }
        }

        private static void FillPhoneBook()
        {
            Contact contact = new Contact(name: "Ruslan", phoneNumber: 79375257001, email: "lar@yandex.ru");
            Dictionary<string, Contact> phoneBook = new Dictionary<string, Contact>();
            AddUnique(new Contact(name: "Zuslan1", phoneNumber: 79375257001, email: "lar@yandex.ru"), ref phoneBook);
            AddUnique(new Contact(name: "Mlmir", phoneNumber: 79375251001, email: "ed@yandex.ru"), ref phoneBook);
            AddUnique(new Contact(name: "Aara", phoneNumber: 79375557001, email: "zar@yandex.ru"), ref phoneBook);

            Console.WriteLine("Исходный список контактов:");
            foreach (var elem in phoneBook)
            {
                Console.WriteLine("Имя:" + elem.Key);
                Console.WriteLine("Номер телефона:" + elem.Value.PhoneNumber);
                Console.WriteLine("Email:" + elem.Value.Email);
            }

            AddUnique(new Contact("Vasya", 79174257512, "vasya@mail.ru"), ref phoneBook);
            AddUnique(new Contact("Valya", 79774267512, "valya@rambler.ru"), ref phoneBook);

            Console.WriteLine("Получившийся список контактов:");
            foreach (var elem in phoneBook)
            {
                Console.WriteLine("Имя:" + elem.Key);
                Console.WriteLine("Номер телефона:" + elem.Value.PhoneNumber);
                Console.WriteLine("Email:" + elem.Value.Email);
            }

            phoneBook["Valya"].PhoneNumber = 79133541211;

            Console.WriteLine();
            Console.WriteLine("Получившийся список контактов:");
            foreach (var elem in phoneBook)
            {
                Console.WriteLine("Имя:" + elem.Key);
                Console.WriteLine("Номер телефона:" + elem.Value.PhoneNumber);
                Console.WriteLine("Email:" + elem.Value.Email);
            }
        }

        private static void AddUnique(Contact contact, ref Dictionary<string, Contact> phoneBook)
        {
            if (phoneBook.ContainsKey(contact.Name)) return;
            phoneBook.Add(contact.Name, contact);
        }

        private static void FillPhoneBookBySortedDictionary()
        {
            Contact contact = new Contact(name: "Ruslan", phoneNumber: 79375257001, email: "lar@yandex.ru");
            SortedDictionary<string, Contact> phoneBook = new SortedDictionary<string, Contact>();
            AddUnique(new Contact(name: "Zuslan1", phoneNumber: 79375257001, email: "lar@yandex.ru"), ref phoneBook);
            AddUnique(new Contact(name: "Mlmir", phoneNumber: 79375251001, email: "ed@yandex.ru"), ref phoneBook);
            AddUnique(new Contact(name: "Aara", phoneNumber: 79375557001, email: "zar@yandex.ru"), ref phoneBook);

            Console.WriteLine("Исходный список контактов:");
            foreach (var elem in phoneBook)
            {
                Console.WriteLine("Имя:" + elem.Key);
                Console.WriteLine("Номер телефона:" + elem.Value.PhoneNumber);
                Console.WriteLine("Email:" + elem.Value.Email);
            }

            AddUnique(new Contact("Vasya", 79174257512, "vasya@mail.ru"), ref phoneBook);
            AddUnique(new Contact("Valya", 79774267512, "valya@rambler.ru"), ref phoneBook);

            Console.WriteLine("Получившийся список контактов:");
            foreach (var elem in phoneBook)
            {
                Console.WriteLine("Имя:" + elem.Key);
                Console.WriteLine("Номер телефона:" + elem.Value.PhoneNumber);
                Console.WriteLine("Email:" + elem.Value.Email);
            }

            phoneBook["Valya"].PhoneNumber = 79133541211;

            Console.WriteLine();
            Console.WriteLine("Получившийся список контактов:");
            foreach (var elem in phoneBook)
            {
                Console.WriteLine("Имя:" + elem.Key);
                Console.WriteLine("Номер телефона:" + elem.Value.PhoneNumber);
                Console.WriteLine("Email:" + elem.Value.Email);
            }
        }

        private static void AddUnique(Contact contact, ref SortedDictionary<string, Contact> phoneBook)
        {
            if (phoneBook.ContainsKey(contact.Name)) return;
            phoneBook.Add(contact.Name, contact);
        }

        private static void ShowStackWorking()
        {
            Stack<string> words = new Stack<string>();
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
            Console.WriteLine();
            string input = string.Empty;
            var exit = false; 
            while (!exit)
            {
                Console.WriteLine("Введите команду:");
                input = Console.ReadLine();

                if (input.Trim().ToLower() == "pop")
                {
                    var temp = string.Empty;
                    words.TryPop(out temp);
                    Console.WriteLine("Последнее извлеченное слово:" + temp);
                    continue;
                }

                if (input.Trim().ToLower() == "peek")
                {
                    var temp = string.Empty;
                    words.TryPeek(out temp);
                    Console.WriteLine("Последнее  добавленное слово в стеке:" + temp);
                    continue;
                }
                if (input.Trim().ToLower() == "exit")
                {
                    exit = true;
                    continue;
                }

                words.Push(input); // Изменить здесь

                Console.WriteLine();
                Console.WriteLine("В стеке:");

                foreach (var word in words)
                {
                    Console.WriteLine(" " + word);
                }
            }
        }

        private static void ShowQueueWorking()
        {
            // объявим потокобезопасную очередь (полностью идентична обычной очереди, но
            // позволяет безопасный доступ
            // из разных потоков)
            ConcurrentQueue<string> words = new ConcurrentQueue<string>();
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в очередь.");
            Console.WriteLine();

            StartQueueProcessing(words);

            while (true)
            {
                var input = Console.ReadLine();
                if (input.Trim().ToLower() == "peek")
                {
                    var cntNum = words.Count;
                    var i = 0;
                    var temp = string.Empty;
                    words.TryPeek(out temp);
                    Console.WriteLine("Крайний элемент в очереди: " + temp);

                    Console.WriteLine();
                }
                else words.Enqueue(input); // ИЗМЕНИТЬ ЗДЕСЬ
            }

        }

        private static void StartQueueProcessing(ConcurrentQueue<string> words)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                while (true)
                {
                    Thread.Sleep(5000);
                    if (words.TryDequeue(out var element))
                        Console.WriteLine("======>  " + element + " прошел очередь");
                }

            }).Start();
        }
    }
}
