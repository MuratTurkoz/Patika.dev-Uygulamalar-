using System;
using System.Collections.Generic;

namespace Proje_1
{
    class Program
    {
        /*
        Yeni bir console uygulaması açarak telefon rehberi uygulaması yazınız. Uygulamada olması gereken özellikler aşağıdaki gibidir.
        Telefon Numarası Kaydet
        Telefon Numarası Sil
        Telefon Numarası Güncelle
        Rehber Listeleme (A-Z, Z-A seçimli)
        Rehberde Arama


        Açıklama:
        Başlangıç olarak 5 kişinin numarasını varsayılan olarak ekleyiniz.
        Uygulama ilk başladığında kullanıcıya yapmak istediği işlem seçtirilir.
        Lütfen yapmak istediğiniz işlemi seçiniz :) 
        *******************************************
        (1) Yeni Numara Kaydetmek
        (2) Varolan Numarayı Silmek
        (3) Varolan Numarayı Güncelleme
        (4) Rehberi Listelemek
        (5) Rehberde Arama Yapmak﻿
        */
        static void Main(string[] args)
        {
            KisiManager kisiManager = new KisiManager();
            kisiManager.ConsoleMenu();
        }
    }
}
