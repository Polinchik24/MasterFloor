//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterPol.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class PartnersImport
    {
        public int Id { get; set; }
        public int IdTypeOfParther { get; set; }
        public int IdPartnerName { get; set; }
        public int IdDirector { get; set; }
        public string EmailOfPartner { get; set; }
        public string PhoneOfPartner { get; set; }
        public int IdAdress { get; set; }
        public long INN { get; set; }
        public int Reiting { get; set; }
    
        public virtual Adress Adress { get; set; }
        public virtual Directors Directors { get; set; }
        public virtual PartnerName PartnerName { get; set; }
        public virtual TypeOfPartner TypeOfPartner { get; set; }
    }
}
