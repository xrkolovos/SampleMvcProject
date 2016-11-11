using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.Db
{
    public class ArticleUser
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string UserId { get; set; }

        [ForeignKey("ArticleId")]
        public Article Articles { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser Users { get; set; }
    }
}