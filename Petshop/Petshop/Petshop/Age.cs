using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Petshop
{
	public abstract class Age
	{

        public abstract double Faktor(Hörcsög h);

        public abstract double Faktor(Pinty p);

        public abstract double Faktor(Tarantula t);

    }

    public class Young : Age
    {
        public override double Faktor(Hörcsög h)
        {
            return 2.0;
        }

        public override double Faktor(Pinty p)
        {
            return 1.0;
        }

        public override double Faktor(Tarantula t)
        {
            return 3.0;
        }
    }

    public class Old : Age
    {
        public override double Faktor(Hörcsög h)
        {
            return 1.0;
        }

        public override double Faktor(Pinty p)
        {
            return 3.0;
        }

        public override double Faktor(Tarantula t)
        {
            return 2.0;
        }
    }


}

