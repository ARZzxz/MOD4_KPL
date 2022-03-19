using System;
using System.Collections.Generic;

namespace Jurnal_MOD4_1302200027
{
    class program
    {
        static void Main(string[] args)
        {
            SimpleDataBase<int> data = new SimpleDataBase<double>();

        }
    }
}

public class penjumlahan
{
    public static void jmlTigaAngka<T>(T data1, T data2, T data3)
    {
        dynamic angkaP = data1;
        dynamic angkaD = data2;
        dynamic angkaT = data3;

        Console.WriteLine(angkaP + angkaD + angkaT + "\n");

    }
}
