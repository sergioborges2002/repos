﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI45_Primeiro_Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] v = new int[10];
            Random rnd = new Random();
            Console.WriteLine("Vetor de 10 elementos aleatórios entre 1 e 20");
            for(i=0;i<v.Length;i++)
            {
                v[i]= rnd.Next(1,20);
            }
            for (i = 0; i < v.Length; i++)
            {
                if (i <= 7 ) {
                Console.Write(v[i]+", "); }
                else if(i == 8)
                {
                    Console.Write(v[i] + " e ");
                }
                else
                {
                    Console.Write(v[i] + ".");
                }
                
            }
            
            Console.ReadKey();
        }
    }
}
