namespace Ders_27_OOP_Abstract
{
    public class Otomobil : IOtomobil
    {
        public Marka Marka { get; set; }
        public int TekerSayisi { get; set; }
        public Renk Renk { get; set; }

        public Marka HangiMarkaninAraci()
        {
            return Marka;
        }

        public int KacTekerlektenOlusur()
        {
            return TekerSayisi = 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk;
        }
    }
}