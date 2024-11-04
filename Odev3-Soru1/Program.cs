// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;

namespace kolesiyonlar
{
    class koleksiyonlar
    {
        static void Main()
        {
            int toplam = 0;
            ArrayList  liste = new ArrayList();
            liste.Add(15);
            liste.Add(22);
            liste.Add(33);
            liste.Add(43);
            liste.Add(52);
            liste.Add(66);
            liste.Add(78);
            foreach (int i in liste)
            {
                Console.WriteLine(i);
                toplam = toplam + i;
            }
            Console.WriteLine("Toplamları:"+toplam);
            

        }
    }
}