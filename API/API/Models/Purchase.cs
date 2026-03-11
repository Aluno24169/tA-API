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
        public int Id { get; set; }

        /// <summary>
        /// Data da compra
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Estado (situação) em que se encontra a compra
        /// </summary>
        public State State { get; set; }
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
