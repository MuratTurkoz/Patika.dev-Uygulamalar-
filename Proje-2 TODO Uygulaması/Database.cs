using System;
using System.Collections.Generic;
using System.Data.Sql;
using System.Linq;
using System.Linq.Expressions;

namespace Proje_2_TODO_Uygulaması
{
    public class Database
    {
        private List<Card> _cards;
        private List<Person> _persons;
        public Database()
        {
            _persons = new List<Person>()
        {
            new Person{ Id=1,Name="Zeki",Team="A"},
            new Person{Id=2,Name="Irmak",Team="B"},
            new Person{Id=3,Name="Selim",Team="B"},
            new Person{Id=4,Name="Ziya",Team="C"},
            new Person{Id=5,Name="Ahmet",Team="B"},
            new Person{Id=6,Name="Oguz",Team="C"},
            new Person{Id=7,Name="Duygu",Team="A"},
            new Person{Id=8,Name="Salih",Team="C"},
        };
            _cards = new List<Card>()
        {
            new Card{Title="C# 101", Content="Patika.dev bitecek. ",Person=_persons[0], Size=Size.XS,BoardType=BoardType.TODO },
            new Card{Title="MVC", Content="Patika.dev bitecek. ", Person=_persons[1], Size=Size.M,BoardType=BoardType.INPROGRESS },
            new Card{Title=".Net", Content="Patika.dev bitecek. ", Person=_persons[2], Size=Size.L,BoardType=BoardType.DONE },
            new Card{Title="Boostrap", Content="Patika.dev bitecek. ", Person=_persons[3], Size=Size.XL,BoardType=BoardType.TODO },
        };


        }
        public void DeleteCard(Card card)
        {
            _cards.Remove(card);
        }
        public void Update(Card card, int res)
        {
            foreach (Card item in _cards)
            {
                if (item == card)
                {
                    item.BoardType = (BoardType)(res - 1);
                }
            }
        }

        public List<Person> GetListPersons()
        {
            return _persons;
        }

        public List<Card> GetListCards()
        {
            return _cards;
        }
        public void CreateCard(Card data)
        {
            _cards.Add(data);

        }

    }

}