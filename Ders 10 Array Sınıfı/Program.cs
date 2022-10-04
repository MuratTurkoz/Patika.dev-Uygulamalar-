// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// int[] dizi = { 11, 2, 31, 14, 25, 46, 57, 38 };
// foreach (int item in dizi)
// {
//     Console.Write(" {0} ", item);
// }
// Console.WriteLine();
// //dizi deki elemanları sıralar....
// Array.Sort(dizi);
// foreach (int item in dizi)
// {
//     Console.Write(" {0} ", item);
// }
// // Verilen elemandan başlayrak sıfırlar kaç terime sıfır atayacağını ifade eder.
// Array.Clear(dizi, 2, 2);
// Console.WriteLine();
// foreach (int item in dizi)
// {
//     Console.Write(" {0} ", item);
// }
// Console.WriteLine();
// //Diziyi tersten sıralar....
// Array.Reverse(dizi);
// foreach (int item in dizi)
// {
//     Console.Write(" {0} ", item);
// }
// Console.WriteLine();
// //IndexOf dizinin elemanlarının kaçıcı index te olduğunu ifade eder.
// Console.WriteLine(Array.IndexOf(dizi, 57));
// //Resizde yeniden boyutlandırma
// Array.Resize(ref dizi, 5);
// // Ya da
// // Array.Resize<int>(ref dizi, 5);
// foreach (int item in dizi)
// {
//     Console.Write(" {0} ", item);
// }

// Console.WriteLine(" ");


List<int> arr = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };
List<int> arr1 = new List<int> { 1, 4, 4, 4, 5, 3 };
List<int> arr3 = new List<int> { 1, 4, 4, 4, 5, 3, 4, 5 };
List<int> arr4 = new List<int> { 5, 5, 5, 5, 5, 5, 5, 5 };
List<int> arr5 = new List<int> { 1, 5, 5, 5, 5, 5, 5, 5 };
List<int> arr6 = new List<int> { 1, 5, 5, 5, 5, 5, 4, 4 };


arr.Sort();
arr1.Sort();
arr3.Sort();
arr4.Sort();
arr5.Sort();
arr6.Sort();


int migratoryBirds(List<int> arr)
{

    SortedList<int, int> sortedList = new System.Collections.Generic.SortedList<int, int>();
    // sortedList.Clear();
    int deger = 1;
    if (arr != null)
    {

        // int[,] array = new int[2, 10];
        // List<int> arr2 = new List<int>();
        // List<int> arrd = new List<int>();

        // int a = 0;
        // int b = 0;
        for (int i = 0; i < arr.Count; i++)
        {

            if (i < arr.Count - 1)
            {
                if (arr[i] == arr[i + 1])
                {
                    deger++;
                    continue;
                }
                else
                {
                    // Console.WriteLine(" {0} degerinden {1} tane var", arr[i], deger);
                    // array[a, b] = arr[i];
                    sortedList.Add(arr[i], deger);

                    // array[a, b + 1] = deger;
                    // b = b + 2;
                    // arr2.Add(arr[i]);

                    deger = 1;
                }
            }
            else if (i == arr.Count - 1)
            {
                sortedList.Add(arr[i], deger);
                // b = b + 2;
                // array[a, b] = arr[i];
                // array[a, b + 1] = deger;
                // Console.WriteLine(" {0} degerinden {1} tane var", arr[i], deger);
                // arr2.Add(arr[i]);
            }

        }


        int result = sortedList.OrderByDescending(x => x.Value).FirstOrDefault().Key;
        return result;
    }
    return deger;
}
// Console.WriteLine(sortedList.Max(x => x.Value).ToString());
// Console.WriteLine(sortedList.OrderByDescending(x => x.Value).FirstOrDefault().Key);



// for (int k = 0; k < 1; k++)
// {
//     for (int j = 0; j < 8; j++)
//     {

//         // Console.Write(array[k, j] + " ");
//     }

// }
// arr2.Sort();
// if (arrd.Count - 1 == arrd.Count - 2)
// {
//     return arr2[arr2.Count - 1];
// }


// // return arr2[arr2.Count - 1];
// if (arr2.Count >= 1 && arr2.Count <= 3)
// {

//     return arr2[arr2.Count - 1];
// }
// else
// {
//     return arr2[arr2.Count - 2];

// }
// arr2.Clear();
// }
Console.WriteLine(migratoryBirds(arr1));
Console.WriteLine(migratoryBirds(arr));
Console.WriteLine(migratoryBirds(arr3));
Console.WriteLine(migratoryBirds(arr4));
Console.WriteLine(migratoryBirds(arr5));
Console.WriteLine(migratoryBirds(arr6));







