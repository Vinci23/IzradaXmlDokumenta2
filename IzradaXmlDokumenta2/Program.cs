using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IzradaXmlDokumenta2
{
    public class Klijent_class
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string EmailAdresa { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Klijent_class> customers = CreateCustomerList();

            var customerXml = new XDocument();
            var rootElem = new XElement("Customers");
            customerXml.Add(rootElem);
            foreach (Klijent_class customer in customers)
            {
                //Pravi novi element koji predstavlja svojstvo Customer
                var customerElem = new XElement("Customer");

                //Dodaje element koji predstavlja svojstvo FirstName za element customer
                var firstNameAttr = new XAttribute("FirstName", customer.Ime);
                customerElem.Add(firstNameAttr);

                //Dodaje element koji predstavlja svojstvo LastName za element customer
                var lastNameAttr = new XAttribute("LastName", customer.Prezime);
                customerElem.Add(lastNameAttr);

                //Dodaje element koji predstavlja svojstvo EmailAddress za element customer
                var emailAddress = new XElement("EmailAdress", customer.EmailAdresa);
                customerElem.Add(emailAddress);

                //Dodaje element customer u XML dokument
                rootElem.Add(customerElem);

            }
            Console.WriteLine(customerXml.ToString());
            Console.Read();
        }

        // Stvara popis klijenata s podacima
        private static List<Klijent_class> CreateCustomerList()
        {
            List<Klijent_class> ListaKlijenata = new List<Klijent_class>
            {
                new Klijent_class
                {
                    Ime = "Ivan",
                    Prezime = "Horvatin",
                    EmailAdresa = "ivan.horvatin@email.com"
                },
                new Klijent_class
                {
                    Ime = "Marko",
                    Prezime = "Ivić",
                    EmailAdresa = "marko.ivic@email.com"
                },
                new Klijent_class
                {
                    Ime = "Josip",
                    Prezime = "Bralić",
                    EmailAdresa = "josip.bralic@email.com"
                },
                new Klijent_class
                {
                    Ime = "John",
                    Prezime = "Horvatin",
                    EmailAdresa = "john.horvatin@email.com"
                },
                new Klijent_class
                {
                    Ime = "Mladen",
                    Prezime = "Marković",
                    EmailAdresa = "marko.markovic@email.com"
                },
                new Klijent_class
                {
                    Ime = "Josip",
                    Prezime = "Kukuljan",
                    EmailAdresa = "josip.kukuljan@email.com"
                },
                new Klijent_class
                {
                    Ime = "Ivan",
                    Prezime = "Crnković",
                    EmailAdresa = "ivan.crnkovic@email.com"
                },
                new Klijent_class
                {
                    Ime = "Joško",
                    Prezime = "Karlautić",
                    EmailAdresa = "josko.karlautic@email.com"
                },
                new Klijent_class
                {
                    Ime = "Anatolij",
                    Prezime = "Uremović",
                    EmailAdresa = "anatolij.uremovic@email.com"
                }
            };
            return ListaKlijenata;
        }
    }
}
