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
    public class Category: IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Name { get; set; }


        public override string ToString()
        {
            return Name;
        }

        public int Id => CategoryId;

    }
}
