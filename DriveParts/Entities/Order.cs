//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DriveParts.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Purchase = new HashSet<Purchase>();
        }
    
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Nullable<int> DeliveryId { get; set; }
        public Nullable<decimal> DeliveryPrice { get; set; }
        public Nullable<int> PaymentMethodId { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public string VIN { get; set; }
        public string Car { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<int> StatusId { get; set; }
        public bool Paid { get; set; }
        public decimal TotalPrice { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Delivery Delivery { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase> Purchase { get; set; }
    }
}
