using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SaveSystem
{
    public class PlayerData
    {
        public int diamond;
        public float money;

        public PlayerData(int diamond, float money)
        {
            this.diamond = diamond;
            this.money = money;
        }        
        public PlayerData()
        {
        }
        public void UpdateDiamond(int diamond)
        {
            this.diamond = diamond;
        }
        public void UpdateMoney(float money)
        {
            this.money = money;
        }

    }
}
