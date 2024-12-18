using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Agenda  
    {
        private List<Contacto> contactos;


        public Agenda()
        {
            contactos = new List<Contacto>();
        }

        public void AddContact(Contacto contacto)
        {
            contactos.Add(contacto);
            Console.WriteLine($"Contacto Added: {contacto.GetName()}");
        }

        public Contacto SearchContact(string name)
        {
            foreach (Contacto contacto in contactos)
            {
                if (contacto.GetName().Equals(name))
                {
                    return contacto;
                }
            }
            return null;
        }

        public bool DeleteContact(string name)
        {
            var contacto = SearchContact(name);
            if (contacto != null) 
            {
                contactos.Remove(contacto);
                Console.WriteLine($"Contacto eliminado: {name}");
                return true;
            }
            Console.WriteLine($"No se encontró el contacto: {name}");
            return false;
        }

        public void ShowContacts()
        {
            if (contactos.Count == 0)
            {
                Console.WriteLine("No hay contactos en la agenda.");
                return;

            }
            Console.WriteLine("Contactos en la agenda: ");
            foreach (Contacto contacto in contactos)
            {
                Console.WriteLine(contacto);
            }
        }
        
        


    }
}
