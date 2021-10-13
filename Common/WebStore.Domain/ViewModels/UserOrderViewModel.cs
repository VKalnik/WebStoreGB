using System;

namespace WebStore.Domain.ViewModels
{
    public class UserOrderViewModel
    {
        public int Id { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public decimal TotalPrice { get; set; }

        public string Description { set; get; }

        public DateTimeOffset Date { get; set; }
    }
}
