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
    }
}
