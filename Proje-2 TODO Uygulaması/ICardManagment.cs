using System.Collections.Generic;

namespace Proje_2_TODO_Uygulaması
{
    public interface ICardManagment
    {
        void Create();
        void Delete(Card card);
        void Update(Card card);
        List<Card> GetCards();

    }

}