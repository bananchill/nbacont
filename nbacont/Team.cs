//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace nbacont
{
    using System;
    using System.Collections.Generic;
    
    public partial class Team
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Team()
        {
            this.MatchUpLog = new HashSet<MatchUpLog>();
            this.PlayerStatistics = new HashSet<PlayerStatistics>();
            this.PlayerTeam = new HashSet<PlayerTeam>();
        }
    
        public int idTeam { get; set; }
        public string Name { get; set; }
        public string Coach { get; set; }
        public string Abbr { get; set; }
        public string Stadium { get; set; }
        public string Logo { get; set; }
        public int Division_idDivision { get; set; }
    
        public virtual Division Division { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatchUpLog> MatchUpLog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayerStatistics> PlayerStatistics { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayerTeam> PlayerTeam { get; set; }
    }
}
