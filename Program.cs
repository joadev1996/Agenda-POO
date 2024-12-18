namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contacto contacto = new("Joa","Federico García", "Don Benito", "622097783", "jchagasn96@gmail.com");

            Console.WriteLine(contacto);

            contacto.SetName("Joaquim Chagas");
            Console.WriteLine(contacto);


            var contacto2 = new Contacto("kkk", "ff", "Meri", "7223230w23", "jajfad@gmail.com");
            var contacto3 = new Contacto("kksk", "ff", "Mersdi", "722w323023", "jajfad@gmail.com");
            var contacto4 = new Contacto("ksdkk", "ff", "Mersdi", "72232qew3023", "jajfad@gmweeail.com");
            var contacto5 = new Contacto("ksdkk", "ff", "Mersdi", "72232w3023", "jajfad@gmail.cqweom");
            
            Console.WriteLine(contacto2);

            Agenda agenda = new Agenda();

            // Agregar contactos

            agenda.AddContact(contacto);
            agenda.AddContact(contacto2);
            agenda.AddContact(contacto3);
            agenda.AddContact(contacto4);
            agenda.AddContact(contacto5);

            // Mostrar contactos

            agenda.ShowContacts();

            // Buscar un contacto

            var lookUp = agenda.SearchContact("kksk");

            if (lookUp != null) { Console.WriteLine($"Contacto encontrado: {lookUp}"); }
            else { Console.WriteLine("No encontrado"); }

            // Eliminar un contacto

            agenda.DeleteContact("Joa");

            // Mostrar resultados finales

            agenda.ShowContacts();

     

            

          
        }
    }
}
