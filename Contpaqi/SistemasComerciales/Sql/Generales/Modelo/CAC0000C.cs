namespace Contpaqi.SistemasComerciales.Sql.Generales.Modelo
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class CAC0000C
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CIDAUTOINCSQL { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string TABLA { get; set; }

        [Required]
        [StringLength(25)]
        public string LARGO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CORTO { get; set; }
    }
}