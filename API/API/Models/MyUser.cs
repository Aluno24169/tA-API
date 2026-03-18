using System.ComponentModel.DataAnnotations;
namespace API.Models
{
    
    /// <summary>
    /// Dados dos clientes da loja
    /// </summary>
    public class MyUser
    {
        /// <summary>
        /// PK
        /// </summary>

        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome do cliente
        /// </summary>
        [StringLength(20)]
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} é de preenchimento obrigátório")]
        public string Name { get; set; }

        /// <summary>
        /// Morada do Cliente
        /// </summary>

        [StringLength(60)]
        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "{0} é de preenchimento obrigátório")]
        public string Address { get; set; }

        /// <summary>
        /// Código postal do cliente
        /// </summary>

        [StringLength(15)]
        [Display(Name = "Código Postal")]
        [Required(ErrorMessage = "{0} é de preenchimento obrigátório")]
        public string PostalCode { get; set; }

        /// <summary>
        /// País da morada do cliente
        /// </summary>

        [StringLength(20)]
        [Display(Name = "País")]
        [Required(ErrorMessage = "{0} é de preenchimento obrigátório")]
        public string Country { get; set; }

        /// <summary>
        /// Número de contribuinte
        /// </summary>

        [StringLength(15)]
        [Display(Name = "Contribuinte")]
        [Required(ErrorMessage = "{0} é de preenchimento obrigátório")]
        public string TaxNumber { get; set; }

        /// <summary>
        /// Número de telemovel do cliente
        /// </summary>

        [StringLength(9)]
        [Display(Name = "Telemóvel")]
        [Required(ErrorMessage = "{0} é de preenchimento obrigátório")]
        public string CellPhone { get; set; }

        /************************************
         * Relacionamentos 1-N
         ************************************/

        /// <summary>
        /// Lista das compras de fotografias efetuadas pelo cliente
        /// </summary>
        public ICollection<Purchase> ListOfPurchase { get; set; }

    }
}
