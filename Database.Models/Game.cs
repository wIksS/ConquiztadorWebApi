namespace GameDb.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Game
    {
        private const int ROWS = 4;
        private const int COLS = 6;

        public Game()
        {
            this.Id = Guid.NewGuid();
            this.Map = new byte[ROWS, COLS];
            this.State = GameState.WaitingForSecondPlayer;
        }

        [Key]
        public Guid Id { get; set; }

        public byte[,] Map { get; set; }

        public GameState State { get; set; }

        [Required]
        public string RedPlayerId { get; set; }

        /// <summary>
        /// The red player
        /// </summary>
        public virtual User RedPlayer { get; set; }

        public string GreenPlayerId { get; set; }

        /// <summary>
        /// The green player
        /// </summary>
        public virtual User GreenPlayer { get; set; }
    }
}
