using System;

namespace TestTetacom.Model
{
    public class GroupedWellStatus
    {
        public int Id { get; set; } // serial4 NOT NULL,
        public int Val { get; set; } // int4 NOT NULL, -- статус скважины
        public int WellId { get; set; }// int4 NOT NULL, -- id скважины
        public float FullDuration { get; set; } //float8 NOT NULL,
        public DateTime StartDt { get; set; } // timestamp NOT NULL, -- дата и время начала статуса
        public DateTime EndDt { get; set; } // timestamp NOT NULL, -- дата и время окончания статуса
        public bool IsDayChange { get; set; } // NOT NULL DEFAULT false, 

        public DateTime? NewDayStartDt { get; set; } // timestamp NULL, 
        public float? NewDayDuration { get; set; } //float8 NULL, 
        public DateTime? OldDayEndDt { get; set; } // timestamp NULL, 
        public float? OldDayDuration { get; set; } // float8 NULL, 
        public float? MdAfter { get; set; } // float8 NULL, 
        public float? MdBefore { get; set; } //float8 NULL, 
        public float? BitDepthAfter { get; set; } //float8 NULL, 

    }
}
