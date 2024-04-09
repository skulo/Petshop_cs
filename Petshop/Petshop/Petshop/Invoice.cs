using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Petshop
{
	public class Invoice
	{
		private string partner;
		public string Partner { get { return partner; } }
		private PetshopClass petshop;
		private Pet pet;
		private int mikor;
		private double mennyiért;
		private bool eladási;

        public bool Eladási { get { return eladási; } }
        public double Mennyiért { get { return mennyiért; } }

        public Invoice(PetshopClass petshop, string partner, Pet pet, int mikor, double mennyiért, bool eladási)
		{
			this.petshop = petshop;
			this.partner = partner;
			this.pet = pet;
			this.mikor = mikor;
			this.mennyiért = mennyiért;
			this.eladási = eladási;
		}

	}
}

