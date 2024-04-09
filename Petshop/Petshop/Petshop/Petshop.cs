using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{
	public class PetshopClass
	{
		private List<Invoice> invoices;

		private List<Pet> pets;

		public PetshopClass()
		{
			invoices = new List<Invoice>();
			pets = new List<Pet>();
		}


        public void Beszerzési(string p, Pet pet, int mi, double me)
        {
            Invoice i = new Invoice(this, p, pet, mi, me, false);
            invoices.Add(i);
            pets.Add(pet);
            pet.Beszerzés(this);

        }
        public void Eladási(string p, string az, int mi, double me, out Pet exit)
		{
            Pet pet = new Hörcsög("asd", "feka", 2141, null, new Young());
            foreach (Pet pett in pets)
			{
				if (pett.Azonosito == az)
				{
					pet = pett;
					break;
				}
			}
			Invoice i = new Invoice(this, p, pet, mi, me, true);
			invoices.Add(i);
			pets.Remove(pet);
			exit = pet;
			pet.Eladás();

		}

		public bool AdottszinuPinty(string szín)
		{
			bool l = false;
			
			foreach (Pet pet in pets)
			{
				if (pet.Faj() == "Pinty" && pet.Szín == szín)
				{
					l = true;
				}

			}
			
			return l;
		}

		public int Hanyhorcsog()
		{
            int c = 0;
            foreach (Pet pet in pets)
            {
				
                if (pet.Faj() == "Hörcsög")
                {
					c += 1;
                }

            }

			return c;
        }

		public double LegertekesebbTarantula()
		{
			double maxtar = 0;

            foreach (Pet pet in pets)
            {

                if (pet.Faj() == "Tarantula" && pet.Érték()>=maxtar)
                {
					maxtar = pet.Érték();
                }

            }
			return maxtar;
        }


		public int AdottPartnerSzerzodes(string p)
		{
			int c = 0;
            foreach (Invoice i in invoices)
            {
				
                if (i.Partner == p)
                {
					c += 1;
                }

            }

			return c;

        }


		public double Nyereseg()
		{
			double plusz = 0;
			double minusz = 0;

            foreach (Invoice i in invoices)
			{
				if (i.Eladási)
				{
					plusz += i.Mennyiért;
				}

				if (i.Eladási == false)
				{
					minusz += i.Mennyiért;
                }
			}

			return plusz - minusz;


        }
	}
}
