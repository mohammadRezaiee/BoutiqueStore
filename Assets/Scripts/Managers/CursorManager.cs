using BS.Tools;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BS.Manager
{
    public class CursorManager
    {
        #region Private Props
        private GameManager _gameManager { get; set; } = null;
        private Texture2D _cursorTexture { get; set; } = null;
        private CursorMode _cursorMode { get; set; } = CursorMode.Auto;
        private Vector2 _hotSpot { get; set; } = Vector2.zero;
        #endregion

        #region Constructor
        public CursorManager(GameManager pGameManger)
        {
            _gameManager = pGameManger;
        }
        #endregion

        #region Public Methods
        public void Init()
        {
            Activity(true);
            _cursorTexture = _gameManager.databaseManger.GetCursorInfoData(ECursorType.Hover).icon;
        }
        public void Activity(bool pActivity)
        {
            Cursor.visible = pActivity;
        }
        public void SetCursorState(ECursorType pCursorType)
        {
            SetCursorTexture(pCursorType == ECursorType.Hover ? _cursorTexture : null);
        }
        #endregion

        #region Private Methods
        private void SetCursorTexture(Texture2D pTexture)
        {
            Cursor.SetCursor(pTexture, _hotSpot, _cursorMode);
        }
        #endregion
    }
}