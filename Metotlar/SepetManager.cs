﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention 
        // syntax
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + product.Adi);

        }

        public void Ekle2(string productAdi, string productAciklama, double fiyat , int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + productAdi);
        }
    }
}
