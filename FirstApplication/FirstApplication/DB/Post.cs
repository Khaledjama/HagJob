using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApplication.DB
{
    public class Post
    {
        public Post()
        {
            this.DateTime = DateTime.Now;
        }
        [Key]
        public int Id { get; set; }
        [Display(Name = "Image")]
        public string Image { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Display(Name = "Mention")]
        public string Mention { get; set; }

        [ForeignKey("ApplicationUser")]
        public string? UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [ForeignKey("Feeling")]
        public int? FeelingId { get; set; }
        public virtual Feeling Feeling { get; set; }
        public DateTime DateTime { get; set; }
    }
}
