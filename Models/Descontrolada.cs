using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel
   .DataAnnotations;
using System.ComponentModel
  .DataAnnotations.Schema;

namespace codeBlox.Models
{
    [Table("descontroladaBD")]
    public class Descontrolada
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [Display(Name = "Preço de venda")]
        public float preco { get; set; }
        [Display(Name = "Descrição")]
        public String descricao { get; set; }
        public int Quantidade { get; set; }

        [Display(Name = "Tipo")]
        public string tipoProduto { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DtCadastro { get; set; }
    }
}