using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Classwork
{
    internal class MenuItems : Drinks
    {
       // Wine Wine = new Wine(); Drinks Drinks = new Drinks(); Food Food = new Food(); Snack Snack = new Snack();

        public int SDdrinks()
        {
            var myDrink = new Drinks();
            string SDrink = myDrink.SoftDrink;

            var cost = 0;



            return cost;
        }




    }


    public class Drinks : VAT, IServingMode
    {
        public string SoftDrink { get; set; }
        public string Wines { get; set; }

        public string cloth()
        {
            throw new NotImplementedException();
        }

        public int FruitJuice()
        {

            return 1000;
        }

        public string servet()
        {
            throw new NotImplementedException();
        }

        public string tissue()
        {
            throw new NotImplementedException();
        }
    }

    public class Wine : VAT, IServingMode
    {
        public string ForeignDrinks { get; set; }
        public string Beer { get; set; }
        public string LocalBeer { get; set; }

        public string cloth()
        {
            throw new NotImplementedException();
        }

        public string servet()
        {
            throw new NotImplementedException();
        }

        public string tissue()
        {
            throw new NotImplementedException();
        }
    }

    public class Food : VAT, IServingMode
    {
        public string LocalMeal { get; set; }
        public string Fries { get; set; }
        public string CarribeanDish { get; set; }

        public string cloth()
        {
            throw new NotImplementedException();
        }

        public string servet()
        {
            throw new NotImplementedException();
        }

        public string tissue()
        {
            throw new NotImplementedException();
        }
    }

    public class Snack : VAT, IServingMode
    {
        public string Sharwama { get; set; }
        public string Pizza { get; set; }
        public string Doughnuts { get; set; }

        public string cloth()
        {
            throw new NotImplementedException();
        }

        public string servet()
        {
            throw new NotImplementedException();
        }

        public string tissue()
        {
            throw new NotImplementedException();
        }
    }

    public class VAT
    {
        int amount;
        public double Vat()
        {
            double Cost = amount * 0.75;
            return Cost;
        }


    }

    public interface IServingMode
    {
        public string servet();
        public string tissue();
        public string cloth();
    }

    public interface ITakeAway
    {
        public string disposable();
        public string reuse();

    }
}
