using Bogus.DataSets;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Nest;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace API.Models
{
    /// <summary>
    /// objetos a serem vendidos na loja
    /// </summary>
    public class Photography
    {
        /// <summary>
        /// PK
        /// </summary>

        [Key]
        public int Id { get; set; }

        /// <summary>
        /// nome associado à fotografia
        /// </summary>

        [StringLength(50)]
        [Display(Name = "Título")]
        [Required(ErrorMessage = "{0} é de preenchimento obrigátório")]
        public string Title { get; set; } = "";

        /// <summary>
        /// descrição (opcional) da fotografia
        /// </summary>

        [Display(Name = "Descrição")]
        [StringLength(500)]
        public string? Description { get; set; }

        /// <summary>
        /// nome do ficheiro que contém a fotografia
        /// </summary>

        public string File { get; set; } = "";

        /// <summary>
        /// data em que a fotografia foi tirada
        /// </summary>

        [Display(Name = "Data")]
        [Required(ErrorMessage = "{0} é de preenchimento obrigátório")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Preço de venda fotografia
        /// </summary>

        [Display(Name = "Preço")]
        public decimal Price { get; set; }

        /************************************
         * Relacionamentos 1-N
         ************************************/

        /// <summary>
        /// FK para a categoria da fotografia
        /// </summary>
        [ForeignKey(nameof(Category))]
        [Display(Name = "Categoria")]
        public int CategoryFK { get; set; }

        [ValidateNever]
        [Display(Name = "Categoria")]
        public Category Category { get; set; } = null!;

        /************************************
         * Relacionamentos M-N
         ************************************/

        /// <summary>
        /// Lista de compras das fotografias
        /// </summary>
        public ICollection<Purchase> ListOfPurchases { get; set; } = [];
    }
}
