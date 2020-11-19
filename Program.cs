using System;

namespace Array_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listaDeCompras = {"maçã", "batata","cenoura", "agua", "coca","Latão","Arroz","feijão","Salsinha","Salpicão"};
            double[] precos = {1.1, 2.3, 4.5};
            int[] idades = {16,17,17};

            string[] nomesAlunos = new string[5];

           // Console.WriteLine(listaDeCompras[1]);

           // Console.WriteLine("trocar batata por qual item?");
           // string item= Console.ReadLine();

           // listaDeCompras[1] = Console.ReadLine();

           //Console.WriteLine(listaDeCompras.Length);

            for (int i = 0; i < listaDeCompras.Length; i++)
            {
                Console.WriteLine(listaDeCompras[i]);
               // Console.WriteLine(i);
               System.Threading.Thread.Sleep(1000);
            }


        }
    }
}
