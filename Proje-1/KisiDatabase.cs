using System.Collections.Generic;

namespace Proje_1
{
    public class KisiDatabase : IDatabase
    {
        private List<Kisi> _rehber;
        List<Kisi> rehber = new List<Kisi>(){
            new Kisi{ Name="Ada",Surname="Çelik",TelNo="5368978462"},
            new Kisi{ Name="Mert",Surname="Kaygı",TelNo="5368978462"},
            new Kisi{Name="Ziya",Surname="yapar",TelNo="5361235487"},
            new Kisi{ Name="Elif",Surname="Hadi",TelNo="5364555779"},
            new Kisi{Name="Müjdat",Surname="Oguz",TelNo="5365464564"},
            new Kisi{Name="Ada",Surname="Oguz",TelNo="5365464564"},
            };

        public KisiDatabase()
        {
            _rehber = rehber;
        }
        public void Create(Kisi kisi)
        {
            _rehber.Add(kisi);
        }

        public void Remove(Kisi kisi)
        {
            _rehber.Remove(kisi);
        }

        public void Update(Kisi kisi, string telNo)
        {
            _rehber.Find(x => x.Name == kisi.Name & x.Surname == kisi.Surname).TelNo = telNo;
        }
        public List<Kisi> List()
        {
            return _rehber;
        }
    }
}
