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
        public string Title { get; set; }

        /// <summary>
        /// descrição (opcional) da fotografia
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// nome do ficheiro que contém a fotografia
        /// </summary>
        public string File { get; set; }

        /// <summary>
        /// data em que a fotografia foi tirada
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Preço de venda fotografia
        /// </summary>
        public decimal Price { get; set; }

        /************************************
         * Relacionamentos 1-N
         ************************************/

        /// <summary>
        /// FK para a categoria da fotografia
        /// </summary>
        [ForeignKey(nameof(Category))]
        public int CategoryFK { get; set; }
        public Category Category { get; set; }

        /************************************
         * Relacionamentos M-N
         ************************************/

        /// <summary>
        /// Lista de compras das fotografias
        /// </summary>
        public ICollection<Purchase> ListOfPurchases { get; set; }
    }
}
