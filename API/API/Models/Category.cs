namespace API.Models
{
    /// <summary>
    /// Possíveis categorias associadas às fotografias
    /// </summary>
    public class Category
    {
        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome da categoria
        /// </summary>
        public string Name { get; set; }
    }
}
