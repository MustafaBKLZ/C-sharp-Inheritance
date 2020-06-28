using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C_sharp_Inheritance.Person
{
    public abstract class Person
    {
        public Person() { }

        //sınıfın sadece türetileceğini
        //belirtmek için sınıfı abstaract keyword’ünü kullanarak soyutladık
        //Ancak burada abstaract keyword’ünün kullanılmasındaki temel
        //faktör bu sınıfın abstract metod içermesidir.


        //Türetilen sınıflarda kullanılmak üzere 4 tane değişken tanımladık.
        protected string Adı;
        protected string Soyadı;
        protected DateTime DogumTarihi;
        protected string Cinsiyeti;


        //Türetilen sınıflarda metodun içi doldurulması için
        //abstract olarak makeAction metodu tanımladık
        public abstract void makeAction();
        // abstract metodlar kesinlikle türetildikleri sınıflarda da tanımlanmalıdır.
        // Eğer burada tanımlanan abstract metodlar, türetildikleri sınıflar kullanılmazlarsa
        // 'Student' does not implement inherited abstract member 'Person.Deneme()'	
        // şeklinde bir hata alırız.

        public abstract void YemekYe();
        public abstract void SuIc();
        public abstract void Calis();
        public abstract void Uyu();
    }
}