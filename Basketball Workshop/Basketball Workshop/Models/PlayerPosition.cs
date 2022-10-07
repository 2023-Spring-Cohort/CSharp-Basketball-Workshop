namespace Basketball_Workshop.Models
{
    public class PlayerPosition
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public virtual Player Player { get; set; }
        public int PositionId { get; set; }
        public virtual Position Position { get; set; }
    }
}

/* 
 Id     PlayerId    Player (Info from Player Class)     PositionId      Position (Info from Position Class)
 1          1       Jim Kocsis                              1           Point Guard
 
 */