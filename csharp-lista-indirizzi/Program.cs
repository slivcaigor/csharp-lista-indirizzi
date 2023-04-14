namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Crea una lista vuota di oggetti Indirizzo e una variabile reader per leggere il file
            List<Indirizzo> indirizzi = new();
            StreamReader? reader = null;

            // contiene il codice che può generare un'eccezione
            try
            {
                // Apre il file addresses.csv in lettura
                reader = new StreamReader("addresses.csv");
                while (!reader.EndOfStream)
                {
                    // Legge il file riga per riga
                    var line = reader.ReadLine();
                    if (line == null)
                    {
                        continue;
                    }

                    // Per ogni riga, divide la stringa in base alla virgola
                    var values = line.Split(',');
                    if (values.Length < 6)
                    {
                        continue;
                    }
                    string name = values[0];
                    string surname = values[1];
                    string street = values[2];
                    string city = values[3];
                    string province = values[4];
                    string zip = values[5];

                    // assegna ogni valore dell'array alle proprietà dell'oggetto Indirizzo
                    Indirizzo indirizzo = new(name, surname, street, city, province, zip);
                    // aggiunge l'oggetto alla lista di indirizzi
                    indirizzi.Add(indirizzo);
                }
                // Stampa ogni indirizzo della lista su console
                foreach (Indirizzo indirizzo in indirizzi)
                {
                    Console.WriteLine(indirizzo);
                }
            }
            // gestisce l'eccezione e fornisce un messaggio di errore all'utente
            catch (Exception e)
            {
                Console.WriteLine("Si è verificato un errore: " + e.Message);
            }
            // il blocco "finally" viene eseguito sempre, sia che ci sia stata un'eccezione sia che non ci sia stata
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
    }
}