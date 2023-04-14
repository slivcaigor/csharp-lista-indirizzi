using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    internal class Indirizzo
    {
        // Proprietà in solo lettura
        public string Name { get; }
        public string Surname { get; }
        public string Street { get; }
        public string City { get; }
        public string Province { get; }
        public string ZIP { get; }

        // Costruttore
        public Indirizzo(string name, string surname, string street, string city, string province, string zip)
        {
            // Assegna i valori delle proprietà con i parametri del costruttore
            Name = name;
            Surname = surname;
            Street = street;
            City = city;
            Province = province;
            ZIP = zip;

            // Eccezioni
            //if (string.IsNullOrEmpty(name))
            //{
            //    throw new ArgumentException("Il nome non può essere vuoto");
            //}
            //if (string.IsNullOrEmpty(surname))
            //{
            //    throw new ArgumentException("Il cognome non può essere vuoto");
            //}
            //if (string.IsNullOrEmpty(street))
            //{
            //    throw new ArgumentException("La via non può essere vuota");
            //}
            //if (string.IsNullOrEmpty(city))
            //{
            //    throw new ArgumentException("La città non può essere vuota");
            //}
            //if (string.IsNullOrEmpty(province))
            //{
            //    throw new ArgumentException("La provincia non può essere vuota");
            //}
            //if (string.IsNullOrEmpty(zip))
            //{
            //    throw new ArgumentException("Il CAP non può essere vuoto");
            //}
        }

        public override string ToString()
        {  // Override del metodo ToString() per restituire una rappresentazione stringa dell'oggetto
            return Name + " " + Surname + ", " + Street + ", " + City + " (" + Province + ") " + ZIP;
        }
    }
}
