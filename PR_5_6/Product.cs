//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PR_5_6
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Opisanie { get; set; }
        public string Proizvoditel { get; set; }
        public Nullable<decimal> Stoimost { get; set; }
        public Nullable<bool> Nalichie { get; set; }
        public Nullable<int> Kolichestvo { get; set; }
    }
}
