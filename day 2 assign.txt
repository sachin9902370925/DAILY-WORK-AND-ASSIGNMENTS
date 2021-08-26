using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp2.models
{
    [Table("MyBooks")]
    public class book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]       
        public int bookID { get; set; }

        [Required]
        public string bookName { get; set; }
        public decimal Price { get; set; }

        [Required]
        public string Author { get; set; }

    }
}
