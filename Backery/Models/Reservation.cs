using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Backery.Models
{
    public class Reservation
    {
        public int id { get; set; }
        public int idProduct { get; set; }

        public string fullName { get; set; }

        public string fullAdress { get; set; }


        public string phone { get; set; }

        public Reservation() { }
        public Reservation(int id, int idProduct, string fullName, string fullAdress, string phone)
        {
            this.id = id;
            this.idProduct = idProduct;
            this.fullAdress = fullAdress;
            this.fullName = fullName;
            this.phone = phone;

        }
    }
}