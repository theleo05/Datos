namespace FormularioDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("persona")]
    public partial class persona
    {
        public int id { get; set; }

        [StringLength(255)]
        public string nombre { get; set; }

        public int? edad { get; set; }

        [StringLength(255)]
        public string carrera { get; set; }

        public int? cuatrimestre { get; set; }
    }
}
