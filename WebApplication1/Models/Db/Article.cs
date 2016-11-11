using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models.Db
{
    public class Article
    {
        public Article()
        {
            DateTimeCreated = DateTimeOffset.Now;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset DateTimeCreated { get; set; }
        public DateTimeOffset? DateTimePublished { get; set; }
        public int? CategoryId { get; set; }
        [MaxLength(128)]
        public string AuthorId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        [ForeignKey("AuthorId")]
        public ApplicationUser Author { get; set; }

        public IList<ArticleUser> ArticleUsers { get; set; }
    }
}