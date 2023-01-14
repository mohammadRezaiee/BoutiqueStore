using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BS.Manager
{
    public class UiManager
    {
        #region Public Props
        #endregion

        #region Private Props
        private GameManager _gameManager { get; set; } = null;
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

        }
        #endregion

        #region Private Methods
        #endregion
    }
}
