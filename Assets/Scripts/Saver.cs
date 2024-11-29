using SaveSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class Saver
    {
        private readonly PlayerData playerData;
        private readonly BaseController controller;
        public Saver(BaseController baseController) 
        {
            playerData = baseController.LoadPlayer();
            controller = baseController;
        }

        public void Save()
        {
            controller.SavePlayer(playerData);
        }
        public void Load() 
        {
            controller.LoadPlayer();
        }

        
    }
}
