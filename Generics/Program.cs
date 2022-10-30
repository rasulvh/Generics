using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Datas<int> datas = new Datas<int>();

            datas.Add(1);
            datas.Add(2);
            datas.Add(3);
            datas.Add(4);
            datas.Add(5);

            foreach (var item in datas.GetAll())
            {
                Console.WriteLine(item);
            }
        }
    }
}