﻿namespace Battleships.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Game
    {
        private ICollection<Ship> ships;
        public Game()
        {
            this.Id = Guid.NewGuid();
            this.Field = new string('O', 64);
            this.State = GameState.WaitingForPlayer;
            this.ships = new HashSet<Ship>();
        }

        public Guid Id { get; set; }

        public string Field { get; set; }

        public GameState State { get; set; }

        [Required]
        public string PlayerOneId { get; set; }

        public virtual ApplicationUser PlayerOne { get; set; }

        public string PlayerTwoId { get; set; }

        public virtual ApplicationUser PlayerTwo { get; set; }

        public virtual ICollection<Ship> Ships
        { 
            get
            {
                return this.ships;
            }

            set
            {
                this.ships = value;
            }
        }
    }
}
