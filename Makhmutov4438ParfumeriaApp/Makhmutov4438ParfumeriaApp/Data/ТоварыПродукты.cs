//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Makhmutov4438ParfumeriaApp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ТоварыПродукты
    {
        public Nullable<int> НомерЗаказа { get; set; }
        public string IdПродукта { get; set; }
        public int Id { get; set; }
        public Nullable<int> Количество { get; set; }
    
        public virtual Заказы Заказы { get; set; }
        public virtual Продукты Продукты { get; set; }
    }
}
