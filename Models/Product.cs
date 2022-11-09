using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROJEKT.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Product name")]
        [Required(ErrorMessage = "The product name is required")]
        public string Name { get; set; }
        [Display(Name = "Price")]
        [Required(ErrorMessage = "The product price is required")]
        public decimal Price { get; set; }
        [Display(Name = "Category")]
        public int CategoryID { get; set; }
        [Display(Name = "Category")]
        public Category Category { get; set; }
        public static void DeleteProduct(int id)
        {
            string ProductDBcs = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Projekt;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection con = new SqlConnection(ProductDBcs);

            string sql = "DELETE FROM Product WHERE Id = " + id.ToString();
            var command = new SqlCommand(sql, con);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }

    }
}
