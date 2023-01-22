using BS.Tools;
using System;
using UnityEngine;

namespace BS
{
    [Serializable]
    public struct CursorInfoData
    {
        #region Public Serialize Fields
        [field: SerializeField] public string name { get; private set; }
        [field: SerializeField] public ECursorType cursorType { get; private set; }
        [field: SerializeField] public Texture2D icon { get; private set; }
        #endregion
    }
}