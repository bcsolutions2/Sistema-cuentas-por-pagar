//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CuentasPorPagar
{
    using System;
    using System.Collections.Generic;
    
    public partial class Documentos_Pagar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Documentos_Pagar()
        {
            this.Solicitud_Pago_Proveedor = new HashSet<Solicitud_Pago_Proveedor>();
        }
    
        public int Num_Documento { get; set; }
        public string Num_Factura { get; set; }
        public int Id_Concepto_Pago { get; set; }
        public System.DateTime Fecha_Documento { get; set; }
        public int Monto { get; set; }
        public System.DateTime Fecha_Registro { get; set; }
        public int Id_Proveedor { get; set; }
        public string Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Solicitud_Pago_Proveedor> Solicitud_Pago_Proveedor { get; set; }
        public virtual Concepto_Pago Concepto_Pago { get; set; }
        public virtual Proveedores Proveedores { get; set; }
    }
}
