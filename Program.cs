using System;
using System.Collections.Generic;
using System.Linq;
using DiagnosaPenyakitTHT.db;
using DiagnosaPenyakitTHT.Models;

namespace DiagnosaPenyakitTHT
{
    class Program
    {
        static void Main(string[] args)
        {
            dbGejala tbl1 = new dbGejala();
            dbPenyakit tbl2 = new dbPenyakit();
            List<int> gejala = new List<int>();

            AppStart:
            Console.WriteLine("//------------------------------------------------------------------------------------------\\");
            Console.WriteLine("||                               Program DIAGNOSA PENYAKIT THT                              ||");
            Console.WriteLine("||__________________________________________________________________________________________||");
            Console.WriteLine("|| By: Rizki Adji Pangestu                                                                  ||");
            Console.WriteLine("\\------------------------------------------------------------------------------------------//");

            Gejala g = null;
            for (int i = 1; i <= tbl1.Gejala.Count; i++)
            {
                g = tbl1.Gejala.Find(f => f.no == i);
                Console.Write(g.message);
                string response = Console.ReadLine();
                if (response.ToLower() == "y" || response.ToLower() == "ya" || response.ToLower() == "iya" || response.ToLower() == "yes")
                    gejala.Add(g.no);
            }

            Penyakit penyakitAnda = tbl2.Penyakit.Find(f => f.no_gejala.SequenceEqual<int>(gejala.ToArray<int>()));
            string[] namaGejala = new string[penyakitAnda.no_gejala.Length];
            for (int i = 0; i < namaGejala.Length; i++)
            {
                namaGejala[i] = tbl1.Gejala.Find(f => f.no == penyakitAnda.no_gejala[i]).name;
            }

            if (penyakitAnda == null)
            {
                Console.WriteLine("\nMaaf penyakit tidak bisa didiagnosa");
            }
            else
            {
                if (penyakitAnda.cancer) Console.WriteLine("\nAnda mengalami Kanker {0}", penyakitAnda.name);
                else if (penyakitAnda.sinus) Console.WriteLine("\nAnda mengalami Sinus {0}", penyakitAnda.name);
                else Console.WriteLine("\nAnda Mengalami {0}", penyakitAnda.name);

                Console.WriteLine("\nDengan Gejala :");
                foreach (var item in namaGejala)
                {
                    Console.WriteLine("> {0}", item);
                }
            }

            Console.Write("\nApa anda ingin di diagnosa ulang ? ");
            string restart = Console.ReadLine();
            if (restart.ToLower() == "ya" || restart.ToLower() == "iya" || restart.ToLower() == "yes")
            {
                Console.Clear();
                goto AppStart;
            }
        }
    }
}
