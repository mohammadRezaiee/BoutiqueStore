using BS.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BS.Manager
{
    [CreateAssetMenu(fileName ="Database", menuName = "BS/New Database", order = 0)]
    public class DatabaseManager : ScriptableObject
    {
        #region Public Serialize Fields
        [field: SerializeField, Header("User : ")] public UserDatabase userDatabase { get; private set; } = null;
        [field: SerializeField, Header("Database : ")] public ClothInfoDatabase clothInfoDatabase { get; private set; } = null;
        [field: SerializeField] public UiDatabase uiDatabase { get; private set; } = null;
        [field: SerializeField, Header("Other : ")] public List<CursorInfoData> cursorInfoData { get; private set; } = new List<CursorInfoData>();
        [field: SerializeField] public GameObject characterShowcaseUiPrefab { get; private set; } = null;
        #endregion

        #region Public Methods
        public CursorInfoData GetCursorInfoData(ECursorType pCursorType)
        {
            CursorInfoData cursorData = cursorInfoData.Find(a => a.cursorType == pCursorType);
            return cursorData;
        }
        #endregion
    }
}
