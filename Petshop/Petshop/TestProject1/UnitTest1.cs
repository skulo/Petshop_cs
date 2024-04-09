using Petshop;
using System.Security.Cryptography.X509Certificates;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LegertekesebbTarantula()
        {
            PetshopClass myPetshop1 = new PetshopClass();
            Assert.AreEqual(0, myPetshop1.Hanyhorcsog());
           
            Pet Tarantula1 = new Tarantula("t1", "fekete", 10000, null, new Young());
            Pet Tarantula2 = new Tarantula("t2", "fekete", 12000, null, new Old());

            double tarantula1ertek = Tarantula1.�rt�k();
            double tarantula2ertek = Tarantula2.�rt�k();

            myPetshop1.Beszerz�si("Lajos", Tarantula1, 2020, 10000);
            myPetshop1.Beszerz�si("Lajos", Tarantula2, 2020, 12000);

            Assert.AreEqual(tarantula1ertek, myPetshop1.LegertekesebbTarantula());

        }

        [TestMethod]
        public void AdottszinuPinty()
        {
            Pet Pinty1 = new Pinty("p1", "fekete", 5000, null, new Young());
            Pet Pinty2 = new Pinty("p2", "sz�rke", 5000, null, new Young());


            PetshopClass myPetshop2 = new PetshopClass();

            myPetshop2.Beszerz�si("Lajos", Pinty1, 2021, 5000);
            myPetshop2.Beszerz�si("B�la", Pinty2, 2021, 5000);

            Assert.AreEqual(false, myPetshop2.AdottszinuPinty("feh�r"));
            Assert.AreEqual(true, myPetshop2.AdottszinuPinty("sz�rke"));

            myPetshop2.Elad�si("Lajos", "p2", 2021, 5000, out Pet exitt2);

            Assert.AreEqual(false, myPetshop2.AdottszinuPinty("sz�rke"));
        }

        [TestMethod]
        public void Hanyhorcsog()
        {
            Pet H�rcs�g1 = new H�rcs�g("h1", "fekete", 5000, null, new Young());
            Pet Pinty1 = new Pinty("p1", "fekete", 5000, null, new Young());
            Pet H�rcs�g2 = new H�rcs�g("h2", "sz�rke", 5000, null, new Young());

            PetshopClass myPetshop3 = new PetshopClass();

            myPetshop3.Beszerz�si("Lajos", H�rcs�g1, 2020, 11000);
            myPetshop3.Beszerz�si("B�la", H�rcs�g2, 2021, 55000);
            myPetshop3.Beszerz�si("B�la", Pinty1, 2021, 5000);

            Assert.AreEqual(2, myPetshop3.Hanyhorcsog());

            myPetshop3.Elad�si("Lajos", "h1", 2021, 5000, out Pet exitt2);
            myPetshop3.Elad�si("Lajos", "h2", 2021, 5000, out Pet exitt3);

            Assert.AreEqual(0, myPetshop3.Hanyhorcsog());
        }

        [TestMethod]
        public void AdottPartnerSzerzodes()
        {
            Pet H�rcs�g1 = new H�rcs�g("h1", "fekete", 5000, null, new Young());
            Pet Pinty1 = new Pinty("p1", "fekete", 5000, null, new Young());
            Pet H�rcs�g2 = new H�rcs�g("h2", "sz�rke", 5000, null, new Young());

            PetshopClass myPetshop4 = new PetshopClass();

            myPetshop4.Beszerz�si("Lajos", H�rcs�g1, 2020, 11000);
            myPetshop4.Beszerz�si("B�la", H�rcs�g2, 2021, 55000);
            myPetshop4.Beszerz�si("B�la", Pinty1, 2021, 5000);

            Assert.AreEqual(1, myPetshop4.AdottPartnerSzerzodes("Lajos"));
            Assert.AreEqual(2, myPetshop4.AdottPartnerSzerzodes("B�la"));

            myPetshop4.Elad�si("Lajos", "h1", 2021, 5000, out Pet exitt2);
            myPetshop4.Elad�si("Lajos", "h2", 2021, 5000, out Pet exitt3);

            Assert.AreEqual(3, myPetshop4.AdottPartnerSzerzodes("Lajos"));
        }

        [TestMethod]
        public void Nyereseg()
        {

            Pet Tarantula1 = new Pinty("t1", "fekete", 5000, null, new Young());
            Pet Pinty1 = new Pinty("p1", "sz�rke", 5000, null, new Old()); 
            Pet H�rcs�g1= new H�rcs�g("h1", "sz�rke", 5000, null, new Old());

            PetshopClass myPetshop5 = new PetshopClass();

            myPetshop5.Beszerz�si("Lajos", Tarantula1, 2021, 5000);
            myPetshop5.Beszerz�si("B�la", Pinty1, 2022, 5000);
            myPetshop5.Beszerz�si("B�la", H�rcs�g1, 2023, 5000);

            Assert.AreEqual(-15000, myPetshop5.Nyereseg());

            myPetshop5.Elad�si("Lajos", "t1", 2023, 7000, out Pet exitt1);
            myPetshop5.Elad�si("Lajos", "p1", 2023, 8000, out Pet exitt2);
            myPetshop5.Elad�si("Lajos", "h1", 2023, 8000, out Pet exitt3);



            Assert.AreEqual(8000, myPetshop5.Nyereseg());
        }
    }
}
