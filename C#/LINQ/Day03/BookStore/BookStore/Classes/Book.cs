using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Classes
{
    #region Some Questions
    //EF automatically makes a property named Id the Primary Key by convention.
    //No explicit configuration is needed unless the name is different.
    //------------------------
    //Value types like decimal are non-nullable by default, so Price becomes not null.
    //Reference types like string? can be nullable, so Country allows null in the database.
    #endregion
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [MaxLength(150)]
        public string Title { get; set; }

        [Required]
        public decimal Price { get; set; }

        public DateTime? PublishedDate { get; set; }
    }
}
