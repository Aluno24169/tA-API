using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{

    /// <summary>
    /// dados da compra de fotografia, por um utilizador
    /// </summary>
    public class Purchase
    {

        /// <summary>
        /// PK
        /// </summary>
        /// 
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Data da compra
        /// </summary>

        [Display(Name = "Data")]
        [Required(ErrorMessage = "{0} é de preenchimento obrigátório")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Estado (situação) em que se encontra a compra
        /// </summary>
        public State State { get; set; }

        /************************************
         * Relacionamentos 1-N
         ************************************/

        /// <summary>
        /// FK para a tabela dos clientes
        /// </summary>

        [ForeignKey(nameof(Buyer))]
        public int BuyerFK { get; set; }

        /// <summary>
        /// cliente que efetuou uma compra
        /// </summary>
        public MyUser Buyer { get; set; }

        /************************************
         * Relacionamentos M-N
         ************************************/

        /// <summary>
        /// Lista de fotografias associadas à compra
        /// </summary>
        public ICollection<Photography> ListOfPhotos { get; set; }
    }


    /// <summary>
    /// Possíveis estados associados a uma compra
    /// </summary>
    public enum State
    {
        Pending,
        Paid,
        Sent,
        Delivered,
        Closed
    }
}
