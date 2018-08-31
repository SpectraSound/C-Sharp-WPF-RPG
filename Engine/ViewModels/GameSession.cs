using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
   public class GameSession
    {
       public Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Spectra";
            CurrentPlayer.Gold = 99999;
            CurrentPlayer.Class = "Fighter";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.EXP = 0;
            CurrentPlayer.Level = 1;
        }
    }
}
