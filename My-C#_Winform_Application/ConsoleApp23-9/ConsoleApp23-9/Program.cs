// See https://aka.ms/new-console-template for more information
using System.Collections;

namespace WinFormsApp_23_9
{
    internal class Program
    {
        private static void Main(string[] arg)
        {
            //2051050001_VuLinh_23/9/2022
            Console.WriteLine("\n Nhap so phantu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu a[" + i + "] = ");
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nhap phan tu can dem: ");
            int dem = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == dem)
                    count++;
                Console.WriteLine("So lan xuat hien cua " + dem + "la: " + count);
                Console.ReadKey();
            }
        }
    }
}

