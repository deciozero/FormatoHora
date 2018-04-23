using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hh = 0;
            int mm = 0;
            string [] aux;
            Console.WriteLine("Digite o primeiro horário no formato hh:mm");
            aux = Console.ReadLine().Split(':');
            hh += int.Parse(aux[0]);
            mm += int.Parse(aux [1]);
            hh += mm / 60;
            mm = mm % 60;
            Console.WriteLine("Total de horas = " + hh + ":" + mm);
            // 
        }
    }
}
