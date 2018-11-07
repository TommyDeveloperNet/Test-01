using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Tablas
{
    [Table("TBL_CLIENTES")]
    [Serializable()]
    public partial class TBL_CLIENTES
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Required()]
        [StringLength(50)]
        [Column(Order = 1)]
        public string NOMBRE { get; set; }

        [StringLength(100)]
        [Column(Order = 2)]
        public string APELLIDOS { get; set; }

        [Required()]
        [StringLength(20)]
        [Column(Order = 3)]
        public string TELEFONO1 { get; set; }

        [StringLength(20)]
        [Column(Order = 4)]
        public string TELEFONO2 { get; set; }

        [StringLength(255)]
        [Column(Order = 5)]
        public string EMAIL { get; set; }

        [Column(Order = 6)]
        public string COMENTARIOS { get; set; }

        /// <summary>
        /// Crea un objeto de tipo TBL_CLIENTES con los elementos a añadir / actualizar
        /// </summary>
        /// <param name="NOMBRE"></param>
        /// <param name="APELLIDOS"></param>
        /// <param name="TELEFONO1"></param>
        /// <param name="TELEFONO2"></param>
        /// <param name="EMAIL"></param>
        /// <param name="COMENTARIOS"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static TBL_CLIENTES Create(string NOMBRE, string APELLIDOS, string TELEFONO1, string TELEFONO2, string EMAIL, string COMENTARIOS, int ID = 0)
        {
            //Declaración
            TBL_CLIENTES objResult;

            //Código
            //-Validaciones...

            //-Asignamos datos
            objResult = new TBL_CLIENTES()
            {
                ID = ID,
                NOMBRE = NOMBRE.Trim(),
                APELLIDOS = APELLIDOS.Trim(),
                TELEFONO1 = TELEFONO1.Trim(),
                TELEFONO2 = TELEFONO2.Trim(),
                EMAIL = EMAIL.Trim(),
                COMENTARIOS = COMENTARIOS.Trim()
            };

            //Resultado
            return objResult;
        }
    }
}
