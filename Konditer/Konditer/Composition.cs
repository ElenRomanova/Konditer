//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Konditer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Composition
    {
        public int IdComposition { get; set; }
        public int IdIngredients { get; set; }
        public int IdProduct { get; set; }
    
        public virtual Ingredients Ingredients { get; set; }
        public virtual Product Product { get; set; }
    }
}
