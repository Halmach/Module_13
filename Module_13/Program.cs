using System;
using System.Collections;
using System.IO;

namespace Module_13
{
    class Program
    {
        static void Main(string[] args)
        {
            uneducatedListWorkShow();
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
    }
}
