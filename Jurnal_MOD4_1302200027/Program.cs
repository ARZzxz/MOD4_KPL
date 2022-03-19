using System;
using System.Collections.Generic;

namespace Jurnal_MOD4_1302200027
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(penjumlahan.jmlTigaAngka<int>(12, 34, 56));

        }
    }
}

public class penjumlahan
{
    public static T jmlTigaAngka<T>(T data1, T data2, T data3)
    {
        dynamic angkaP = data1;
        dynamic angkaD = data2;
        dynamic angkaT = data3;

       return angkaP + angkaD + angkaT;

    }
}
