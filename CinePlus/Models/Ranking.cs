namespace CinePlus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ranking
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public int Score { get; set; }

        public virtual Movy Movy { get; set; }
    }
}
