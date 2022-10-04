using System;
using System.Collections.Generic;

namespace Proje_2_TODO_Uygulaması
{
    public class CardManagment : ICardManagment
    {
        Database _dt;
        public CardManagment()
        {
            _dt = new Database();
        }
        public void Create(Card card)
        {
            _dt.CreateCard(card);
        }

        public void Create()
        {
            throw new System.NotImplementedException();
        }

        public int Delete(string val)
        {
            if (FindCard(val) != null)
            {
                _dt.DeleteCard(FindCard(val));
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public List<Card> GetCards()
        {
            return _dt.GetListCards();
        }

        public void Update(Card card, int res)
        {
            _dt.Update(card, res);
        }
        public Person FindPerson(string name)
        {
            List<Person> _persons = _dt.GetListPersons();
            foreach (Person item in _persons)
            {
                if (name.ToLower() == item.Name.ToLower())
                {
                    return item;
                }
            }
            return null;
        }
        public Card FindCard(string name)
        {
            List<Card> _cards = _dt.GetListCards();
            foreach (Card item in _cards)
            {
                if (name.ToLower() == item.Title.ToLower())
                {
                    return item;
                }
            }
            return null;
        }

        public void Delete(Card card)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Card card)
        {
            throw new NotImplementedException();
        }
    }

}