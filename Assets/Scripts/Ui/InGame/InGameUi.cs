using BS.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BS.Ui
{
    public class InGameUi : MonoBehaviour
    {
        #region Public Props
        public CalenderUiItem calendarUiItem
        {
            get
            {
                if(_calendarUiItem == null)
                {
                    _calendarUiItem = GetComponentInChildren<CalenderUiItem>(true);
                }

                return _calendarUiItem;
            }
        }
        public WalletUiItem walletUiItem
        {
            get
            {
                if(_walletUiItem == null)
                {
                    _walletUiItem = GetComponentInChildren<WalletUiItem>(true);
                }

                return _walletUiItem;
            }
        }
        #endregion

        #region Private Props
        private GameManager _gameManager => _gameManagerRef != null ? _gameManagerRef : (GameManager.Instance);
        private GameManager _gameManagerRef { get; set; } = null;
        private CalenderUiItem _calendarUiItem { get; set; } = null;
        private WalletUiItem _walletUiItem { get; set; } = null;
        #endregion

        #region Unity Mehtods
        private void Awake()
        {
            _gameManager.uiManager.RegisterUi(this);
        }
        private void Start()
        {
            calendarUiItem.Init();
            walletUiItem.Init();
        }
        #endregion
    }
}
