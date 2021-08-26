using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace ConsoleApp2.models
{
    
        [Table("Order")]
        public class Order
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
            public int Order_ID { get; set; }

            public DateTime OrderDate { get; set; }

            [Column("OrderAmt")]
            public int Amount { get; set; }

            public Customer Cust { get; set; } //navigation prop
        public object Orders { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }


}
