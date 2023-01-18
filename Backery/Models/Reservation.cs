using System;
using System.Collections.Generic;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Backery.Models
{
    public class Reservation
    {
        public int id { get; set; }

        public string fullName { get; set; }

        public string fullAdress { get; set; }

        public string phone { get; set; }

        public ICollection<Product> Products { get; set; }

        public Product linkProduct(Product product) {
            Products.Add(product);
            return product;
        }

        public Product unlinkProduct(Product product) {
            Products.Remove(product);
            return product;
        }

        public Reservation() { }
        public Reservation(string fullName, string fullAdress, string phone)
        {
            this.fullAdress = fullAdress;
            this.fullName = fullName;
            this.phone = phone;
        }
    }
}