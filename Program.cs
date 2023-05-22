namespace PäriluseRakendus
{
    class Program
    {
        static void Main(string[] args)
        {
            Koer koer = new Koer();
            koer.Nimi = "Rex";
            koer.Võimekus = "Haukumine";

            koer.Tervita();
            koer.TeeHäälitsus();

            Console.ReadLine();
        }
    }

    class Loom
    {
        public string Nimi { get; set; }

        public void Tervita()
        {
            Console.WriteLine("Tere, olen " + Nimi);
        }
    }
    // Pärilus (inheritance) toimub siin klasside "Koer" ja "Loom" vahel.
// Klass "Koer" laiendab (inherit) klassi "Loom", tähendades, et "Koer" klass pärib "Loom" klassi omadused ja meetodid.
// See võimaldab "Koer" klassil kasutada nii enda unikaalseid omadusi ja meetodeid kui ka "Loom" klassi üldisi omadusi ja meetodeid.
// "Koer" klass lisab omaduse "Võimekus" ja meetodi "TeeHäälitsus", samas kui "Loom" klassil on omadus "Nimi" ja meetod "Tervita".

    class Koer : Loom
    {
        public string Võimekus { get; set; }

        public void TeeHäälitsus()
        {
            Console.WriteLine(Nimi + " teeb häält: " + Võimekus);
        }
    }
}