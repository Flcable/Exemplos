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
    
    public partial class tb_pro_produto
    {
        public int pro_codigo { get; set; }
        public string pro_nome { get; set; }
        public Nullable<int> frn_codigo { get; set; }
        public Nullable<int> cat_codigo { get; set; }
        public string pro_embalagem { get; set; }
        public Nullable<short> pro_estoque { get; set; }
        public Nullable<short> pro_estoque_minimo { get; set; }
        public bool pro_descontinuado { get; set; }
        public Nullable<decimal> pro_valor_unitario { get; set; }
    
        public virtual tb_cat_categoria tb_cat_categoria { get; set; }
        public virtual tb_for_fornecedor tb_for_fornecedor { get; set; }
    }
}
