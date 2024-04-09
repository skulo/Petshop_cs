using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFile;

namespace Petshop;

class Program

{
    static void Main(string[] args)
    {
        PetshopClass petshop = new PetshopClass();
        BuyAnimals(petshop, "adatok.txt");

        Console.WriteLine(petshop.AdottPartnerSzerzodes("Lajos"));
        Console.WriteLine(petshop.Hanyhorcsog());
        Console.WriteLine(petshop.AdottszinuPinty("fehér"));

        petshop.Eladási("Pista", "t2", 20221113, 120000, out Pet exit1);

        Console.WriteLine(petshop.LegertekesebbTarantula());
        Console.WriteLine(petshop.Nyereseg());



    }
    static void BuyAnimals(PetshopClass petshop, string fname)
    {
        TextFileReader reader = new TextFileReader(fname);
        char[] separators = new char[] { ' ', '\t' };
        while (reader.ReadLine(out string line))
        {
            string[] tokens = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string partner = tokens[0];
            string az = tokens[1];
            string faj = tokens[2];
            Age age = null;
            switch (tokens[3])
            {
                case "Young":
                    age = new Young();
                    break;
                case "Old":
                    age = new Old();
                    break;
            }
            string szin = tokens[4];
            int mi = int.Parse(tokens[5]);
            double me = double.Parse(tokens[6]);
            Pet p = null;
            switch (faj)
            {
                case "Pinty":
                    p = new Pinty(az, szin, me, petshop, age);
                    break;
                case "Tarantula":
                    p = new Tarantula(az, szin, me, petshop, age);
                    break;
                case "Hörcsög":
                    p = new Hörcsög(az, szin, me, petshop, age);
                    break;
            }
            petshop.Beszerzési(partner, p, mi, me);
        }
    }
}