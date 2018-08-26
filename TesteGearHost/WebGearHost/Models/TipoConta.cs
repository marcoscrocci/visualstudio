using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinanceiroWeb.Models
{
    public class TipoConta: Entidade
    {
        //[Required(ErrorMessage = "O campo \"{0}\" é obrigatória")]
        //[StringLength(50, ErrorMessage = "O tamanho máximo para o campo \"{0}\" é de 50 caracteres")]
        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        public ICollection<Conta> Contas { get; set; }
    }
}
