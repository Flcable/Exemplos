//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Exemplos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_tra_transportadora
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_tra_transportadora()
        {
            this.tb_ven_venda = new HashSet<tb_ven_venda>();
        }
    
        public int tra_codigo { get; set; }
        public string tra_nome { get; set; }
        public string tra_telefone { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ven_venda> tb_ven_venda { get; set; }
    }
}
