namespace GameDb.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Game
    {
        public Game()
        {
            this.Id = Guid.NewGuid();
            this.Map = new byte[4, 6];
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
