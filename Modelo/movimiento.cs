//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Distribuidora.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class movimiento
    {
        public short idTipoMovimiento { get; set; }
        public int idTarjeta { get; set; }
        public System.DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; }
        public string Agente { get; set; }
        public decimal Saldo { get; set; }
        public System.DateTime FechaAbono { get; set; }
    
        public virtual tarjeta tarjeta { get; set; }
        public virtual tipomovimiento tipomovimiento { get; set; }
    }
}