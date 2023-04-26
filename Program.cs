using csharp_lista_indirizzi;
using System.Data;
using System.IO;
using System.Xml.Linq;

List<Address> listaInformazioniIndirizzi = new List<Address>();

try
{
    StreamReader file = File.OpenText("C:/Users/Red/Desktop/.NET/C#/csharp-lista-indirizzi/csharp-lista-indirizzi/addresses.csv");
    int righeLette = 0;

    while (!file.EndOfStream)
    {
        string rigaSingola = file.ReadLine();
        righeLette++;

        if (righeLette > 1)
        {
            string[] singleInfo = rigaSingola.Split(',');

            if (singleInfo.Length != 6)
            {
                Console.WriteLine("La riga " + righeLette + " è errata");
            }
            else
            {
                int zipAddress = int.Parse(singleInfo[5]);

                try
                {
                    Address addressInfos = new Address(singleInfo[0], singleInfo[1], singleInfo[2], singleInfo[3], singleInfo[4], zipAddress);
                    listaInformazioniIndirizzi.Add(addressInfos);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Errore alla riga " + righeLette);
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
catch (Exception e)
{
    
    Console.WriteLine("Errore:");
    Console.WriteLine(e.Message);
}

foreach (Address address in listaInformazioniIndirizzi)
{
    Console.WriteLine(address);
}