using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Shared.Entities
{
    public class Country
    {
        // PK Id por convención suele convertirse en clave primaria cuando usas Entity Framework
        // (EF). Si usas EF y no pones otra configuración, EF asumirá que Id es la PK
        public int Id { get; set; }
        //Indica cómo se debe mostrar el nombre de esa propiedad en la UI
        //(formularios, etiquetas, mensajes).
        [Display(Name = "Pais")]

        //Si el usuario deja el campo vacío y se ejecuta la validación del modelo (por ejemplo en un
        //formulario MVC), aparecerá el ErrorMessage con {0} reemplazado (por ejemplo "El campo Pais es
        //requerido").
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        //Si el usuario deja el campo vacío y se ejecuta la validación del modelo (por ejemplo en un
        //formulario MVC), aparecerá el ErrorMessage con {0} reemplazado (por ejemplo
        //"El campo Pais es requerido").
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Name { get; set; } = null!;

    }
}
