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
    
    public partial class PlayerTeam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlayerTeam()
        {
            this.PlayerStatistics = new HashSet<PlayerStatistics>();
        }
    
        public int idPlayerTeam { get; set; }
        public string ShirtNumber { get; set; }
        public decimal Salary { get; set; }
        public int StarterIndezx { get; set; }
        public int Player_idPlayer { get; set; }
        public int Team_idTeam { get; set; }
        public int Season_idSeason { get; set; }
    
        public virtual Player Player { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayerStatistics> PlayerStatistics { get; set; }
        public virtual Season Season { get; set; }
        public virtual Team Team { get; set; }
    }
}