using System;

namespace Ders_27_OOP_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus ff = new Focus();
            Console.WriteLine(ff.HangiMarkaninAraci() + " " + ff.StandartRengiNe() + " " + ff.KacTekerlektenOlusur());

        }
    }
}
