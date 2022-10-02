using System.Collections.Generic;

namespace Proje_1
{
    public interface IKisiManager
    {
        void Create();
        void Update();
        void Delete();
        // void GetKisi(Kisi item);
        void GetKisiler();
        void GetTelByKisiler(string val);
        void GetNameByKisiler(string val);
        List<Kisi> FindOfKisi(string vals);
    }
}