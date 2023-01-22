using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BS.Tools
{
    [CreateAssetMenu(fileName = "ClothInfoDatabase", menuName = "BS/New ClothInfoDatabase", order = 0)]
    public class ClothInfoDatabase : ScriptableObject
    {
        #region Public Serialzie Fields
        [field: SerializeField] public List<ClothInfoData> clothInfoDataList { get; private set; } = null;
        #endregion

        #region Public Methods
        public ClothInfoData GetData(EClothSeasonType pSeasonType)
        {
            return clothInfoDataList.Find(cloth => cloth.seasonType == pSeasonType);
        }
        #endregion
    }
    [Serializable]
    public class ClothInfoData
    {
        #region IClothData Serialize Props
        [field: SerializeField] public EClothSeasonType seasonType { get; private set; }
        [field: SerializeField] public string seasonName { get; private set; }
        [field: SerializeField] public List<ClothData> clothList {get; private set;}
        
        #endregion
    }
}
