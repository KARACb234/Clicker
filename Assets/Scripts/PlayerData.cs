using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SaveSystem
{
    public class PlayerData
    {
        public float gold;
        public float money;

        public PlayerData(float gold, float money)
        {
            this.gold = gold;
            this.money = money;
        }        
        public PlayerData()
        {
        }

    }
}
