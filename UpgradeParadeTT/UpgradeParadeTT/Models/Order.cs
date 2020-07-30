using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace UpgradeParadeTT.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public DeliveryTypes DeliveryType { get; set; }

        public PaymentTypes PaymentType { get; set; }

        public virtual Customer Customer { get; set; }

        public int ProductId { get; set; }

        [NotMapped]
        public virtual Product Product { get; set; }
    }
}
