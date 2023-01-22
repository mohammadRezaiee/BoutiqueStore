using System;

namespace BS.Tools
{
    [Serializable]
    public class ClothData
    {
        #region Public Props
        public EClothType clothType;
        public EClothSeasonType seasonType;
        public EGenderType genderType;
        public string name;
        public string id;
        public string des;
        #endregion
    }
}
