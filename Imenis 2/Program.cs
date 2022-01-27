internal class Program
{
    public static void Main()
    {
        bool izlaz = false;
        List<Osoba> osobe = new();
        List<Email> emails = new();

        do
        {
            StampajMeni();
            string meni = Console.ReadLine();

            switch (meni)
            {
                case "1":
                    ImenIPrezime();
                    break;

                case "2":
                    EmailAdresa();
                    break;

                case "3":
                    PrikazOsobe();
                    break;

                case "4":
                    PrikazEmaila();
                    break;

                case "5":
                    dovidjenja();
                    break;

                default:
                    Console.WriteLine("ERROR");
                    Console.ReadLine();
                    break;
            }
            Console.Clear();

        } while (!izlaz);

        //Ova funkcija nam stampa meni
        void StampajMeni()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("1. Unos osobe                |");
            Console.WriteLine("2. Unos E-mail adrese        |");
            Console.WriteLine("3. Prikaz osoba              |");
            Console.WriteLine("4. Prikaz email              |");
            Console.WriteLine("5. Izlaz                     |");
            Console.WriteLine("==============================");
        }

        //Ova funkcija sluzi za upis imena i prezimena
        void ImenIPrezime()
        {
            Osoba o = new();
            Console.Write("Unesite ime: ");
            o._name = Console.ReadLine();
            Console.Write("Unesite prezime: ");
            o._surname = Console.ReadLine();

            osobe.Add(o);

            foreach (Osoba neko in osobe)
            {
                Console.WriteLine($"{neko._name} {neko._surname}");
            }
        }

        //Ova funkcija nam sluzi za upis email adrese
        void EmailAdresa()
        {
            Email e = new();
            Console.Write("Unesite vasu Email adresu: ");
            e._email = Console.ReadLine();

            emails.Add(e);

            foreach (Email neki in emails)
            {
                Console.WriteLine($"{neki._email}");
            }
        }

        //Ova funkcija nam prikazuje osobe 
        void PrikazOsobe()
        {
            foreach (Osoba neko in osobe)
            {
                Console.WriteLine($"{neko._name} {neko._surname}");
            }
            Console.ReadKey();
        }

        //Ova funkcija nam prikazuje email adresu
        void PrikazEmaila()
        {
            foreach (Email neki in emails)
            {
                Console.WriteLine($"{neki._email}");
            }
            Console.ReadKey();
        }

        //Ova funkcija nam sluzi da ugasimo program
        void dovidjenja()
        {
            Console.WriteLine("Dovidjenja");
            Console.ReadLine();
            izlaz = true;
        }
    }
}

internal class Osoba
{
    public string _name;
    public string _surname;
}
internal class Email
{
    public string _email;
}