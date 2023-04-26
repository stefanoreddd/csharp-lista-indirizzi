using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{

    //CLASSE
    internal class Address
    {
        private string name;
        private string surname;
        private string street;
        private string city;
        private string province;
        private int zip;



        //COSTRUTTORE
        public Address(string name, string surname, string street, string city, string province, int zip)
        {
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.zip = zip; 
        } 


        //GETTERS

        public string GetName()
        {
            return this.name;
        }

        public string GetSurname()
        {
            return this.surname;
        }

        public string GetStreet()
        {
            return this.street;
        }

        public string GetCity()
        {
            return this.city;
        }

        public string GetProvince()
        {
            return this.province;
        }

        public int GetZip()
        {
            return this.zip;
        }


        //SETTERS

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetSurname(string surname)
        {
            this.surname = surname;
        }

        public void SetStreet(string street)
        {
            this.street = street;
        }

        public void SetCity(string city)
        {
            this.city = city;
        }

        public void SetProvince(string province)
        {
            this.province = province;
        }

        public void SetZip(int zip)
        {
            this.zip = zip;
        }


        //METODI

        public override string ToString()
        {
            string addressList =
            "------ INDIRIZZO ------ \n" +
            $"Nome: {this.name} \n" +
            $"Cognome: {this.surname} \n" +
            $"Via: {this.street} \n" +
            $"Città: {this.city} \n" +
            $"Stato: {this.province} \n" +
            $"Zip: {this.zip} \n";

            return addressList;
        }
    }

}
