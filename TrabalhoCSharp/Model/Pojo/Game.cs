using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoCSharp.Model.Repostiory;

namespace TrabalhoCSharp.Model.Pojo
{
    public class Game: IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GameId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public int PublishYear { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Description { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public virtual Category Category { get; set; }

        public int Id => GameId;

    }
}
