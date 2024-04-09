using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Petshop
{
	public abstract class Pet
	{
		protected string azonosito;
		protected string szin;
		protected int szorzo;
		protected double aktar;
		protected PetshopClass petshop;
		protected Age age;
        public string Szín { get { return szin; } }
        public string Azonosito { get { return azonosito; } }
		

        public Pet(string azonosito, string szin, double aktar, PetshopClass petshop, Age age)
		{
			this.azonosito = azonosito;
			this.szin = szin;
			this.aktar = aktar;
			this.petshop = petshop;
			this.age = age;
		}

		public abstract string Faj();
		public abstract double Érték();

		public void Eladás()
		{
			this.petshop = null;
		}

		public void Beszerzés(PetshopClass petshop)
		{
			this.petshop = petshop;
		}

	}

		public class Hörcsög : Pet
		{
			public Hörcsög(string azonosito, string szin, double aktar, PetshopClass petshop, Age age) : base(azonosito, szin, aktar, petshop, age)
			{

			}

			public override double Érték()
			{
				return aktar * age.Faktor(this);

			}


			public override string Faj()
			{
				return "Hörcsög";
			}

		}

    public class Tarantula : Pet
    {

        public Tarantula(string azonosito, string szin,  double aktar, PetshopClass petshop, Age age) : base(azonosito, szin, aktar, petshop, age)
        {

        }


        public override double Érték()
        {
            return aktar * age.Faktor(this);

        }


        public override string Faj()
        {
            return "Tarantula";
        }

    }

    public class Pinty : Pet
    {
        public Pinty(string azonosito, string szin, double aktar, PetshopClass petshop, Age age) : base(azonosito, szin, aktar, petshop, age)
        {

        }

        public override double Érték()
        {
            return aktar * age.Faktor(this);

        }


        public override string Faj()
        {
            return "Pinty";
        }

    }






}

