using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BS.Tools
{
    public interface IClothData
    {
        #region Props
        public EClothType clothType { get; }
        public EClothSeasonType seasonType { get; }
        public string name { get; }
        public string id { get; }
        public string des { get; }
        public Sprite icon { get; }
        #endregion
    }
}
