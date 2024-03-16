using System;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace UMainGame
{
    public class MainGame
    {
        public void SendGameSpeed()
        {
            BaseComponent baseComponent = Tutorial.GameEntry.Base;
            Log.Info("GameSpeed {0}", baseComponent.GameSpeed);
        }
    }
}