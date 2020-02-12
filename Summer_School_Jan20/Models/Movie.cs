using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Summer_School_Jan20.Models
{
    public class Movie
    {
        [Key]
        [Display(Name = "Movie ID")]
        [Required(ErrorMessage = "Movie ID requu=ired")]
        public int Id { get; set; }

        [Display(Name = "Name:")]
        public string Name { get; set; }

        [Display(Name = "Surname:")]

        public string Surname { get; set; }

        [Display(Name = "Email:")]
        public string Email { get; set; }

        [Display(Name = "Cell Number:")]
        [DataType(DataType.PhoneNumber)]
        public int CellNumber { get; set; }

        [Display(Name ="Crean Type:")]
        public string CreanType { get; set; }
        


        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        public DateTime date { get; set; }

        [Display(Name = "Time")]
        public String Time { get; set; }

        [Display(Name = "Number Of Seat:")]
        public int NumberOfSeat { get; set; }

        [Display(Name = "Number Of Parking:")]
        public double numOfParking { get; set; }

        public int Parking { get; set; }
        public int Price { get; set; }
        public double Discount { get; set; }
        public double total { get; set; }


        // Price calculation
        public int calcCreanTypePrice()
        {
            if (CreanType == "2D" && NumberOfSeat !=0)
            {
                Price =NumberOfSeat*70;
            }
            else if(CreanType=="3D" && NumberOfSeat != 0)
            {
                Price = NumberOfSeat*100;
            }
            return Price;
        }

        // calculate Discount
        public double calcDisount()
        {
            if (NumberOfSeat > 5)
            {
                Discount = calcCreanTypePrice() * 0.15;
            }
            else
            {
                Discount = 0;
            }
            return Discount;
        }

    //  Total calculation wihtout a parking
        public double CalcTotalPriceNoparking ()
        {
            total = calcCreanTypePrice() - calcDisount();
            return total;
        }

        //parking fee calculation
        public double calcParkingFee()
        {

            numOfParking = numOfParking * 20;
            return numOfParking;

        }

        //// Calc Max Total
        public double CalcTotalwithParking()
        {
            double Maxtoal;
            return Maxtoal = CalcTotalPriceNoparking() + calcParkingFee();
        }

    }
}