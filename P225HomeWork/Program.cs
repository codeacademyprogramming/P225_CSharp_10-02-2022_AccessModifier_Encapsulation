using System;

namespace P225HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Home Work - 1
            //Ədədlərdən ibarət array qəbul edən method yazın.
            //Array sort metoduna uyğun CustomSort(int[] arr) metodunu yazın.

            //int[] arr = { 3, 2, 6, 8, 9 ,1};

            //foreach (int item in CustomSort(arr))
            //{
            //    Console.Write(item + " ");

            //}
            #endregion

            #region Home Work - 2
            //Stringlerden ibaret array-i və char qəbul edən metod yazın.
            //Arrayin hansi index-də bu qəbul edilən char varsa, o string-ləri ekranda yazdirin

            string[] arr = { "Salam", "Sagol", "Nagarirsan" };

            char a = 'g';

            foreach (string item in CheckChar(arr, a))
            {
                Console.WriteLine(item);
            }
            #endregion
        }

        #region Home Work - 1
        //Ədədlərdən ibarət array qəbul edən method yazın.
        //Array sort metoduna uyğun CustomSort(int[] arr) metodunu yazın.
        static int[] CustomSort(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                        

                }
            }
            return arr;
        }
        #endregion

        #region Home Work - 2
        //Stringlerden ibaret array-i və char qəbul edən metod yazın.
        //Arrayin hansi index-də bu qəbul edilən char varsa, o string-ləri ekranda yazdirin
        static string[] CheckChar(string[] arr,char a)
        {
            string[] result = new string[0];

            foreach (string item in arr)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i] == a)
                    {
                        //Arrayda Yeni Index - Yer Yaradir Arrayin Sonunda
                        Array.Resize(ref result, result.Length + 1);

                        //Arrayda Yaradilan Yeni Index Data Elvemk Ucun
                        result[result.Length - 1] = item;
                        break;
                    }

                }
            }

            return result;
        }


        #endregion
    }
}
