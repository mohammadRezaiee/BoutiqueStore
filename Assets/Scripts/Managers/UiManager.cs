using BS.Ui;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BS.Manager
{
    public class UiManager
    {
        #region Public Props
        public InGameUi inGameUi => _inGameUi != null ? _inGameUi : (_inGameUi = Object.FindObjectOfType<InGameUi>());
        #endregion

        #region Private Props
        private GameManager _gameManager { get; set; } = null;
        private InGameUi _inGameUi { get; set; } = null;
        #endregion

        #region Constructor
        public UiManager(GameManager pGameManager)
        {
            _gameManager = pGameManager;
        }
        #endregion

        #region Public Methods
        public UiManager Init()
        {
            return this;
        }
        public void RegisterUi<T>(T pUi) where T: class
        {
            if(typeof(T) == typeof(InGameUi))
            {
                _inGameUi = pUi as InGameUi;
            }
        }
        #endregion

        #region Private Methods
        #endregion
    }
}
