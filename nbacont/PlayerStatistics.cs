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
    
    public partial class PlayerStatistics
    {
        public int idPlayerStatistics { get; set; }
        public int IsStarting { get; set; }
        public int Min { get; set; }
        public int Point { get; set; }
        public int Assist { get; set; }
        public int FieldGoalMade { get; set; }
        public int FieldGoalMissed { get; set; }
        public int C3_PointFieldGoalMade { get; set; }
        public int C3_pointFieldGoalMissed { get; set; }
        public int FreethrowMade { get; set; }
        public int FreethrowMissed { get; set; }
        public int Rebound { get; set; }
        public int OFFR { get; set; }
        public int DFFR { get; set; }
        public int Steal { get; set; }
        public int Block { get; set; }
        public int Turnover { get; set; }
        public int Foul { get; set; }
        public int MatchUp_idMatchUp { get; set; }
        public int Team_idTeam { get; set; }
        public int PlayerTeam_idPlayerTeam { get; set; }
    
        public virtual MatchUp MatchUp { get; set; }
        public virtual PlayerTeam PlayerTeam { get; set; }
        public virtual Team Team { get; set; }
    }
}
