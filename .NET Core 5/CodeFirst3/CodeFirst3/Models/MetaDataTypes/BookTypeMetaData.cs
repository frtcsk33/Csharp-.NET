using System.ComponentModel.DataAnnotations;

namespace CodeFirst3.Models.MetaDataTypes
{
    public class BookTypeMetaData
    {
        [Required(ErrorMessage = "Zorunlu alan")]
        [MaxLength(15, ErrorMessage = "maksimum 15 karakter girebilirsiniz")]
        public string Name { get; set; }
    }
}
