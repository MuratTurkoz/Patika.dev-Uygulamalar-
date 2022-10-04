namespace Proje_1
{
    public interface IDatabase
    {
        void Create(Kisi kisi);
        void Remove(Kisi kisi);
        void Update(Kisi kisi, string telNo);
    }
}