using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BS.Manager
{
    public class GameManager : MonoBehaviour
    {
        #region Public Static Props
        public static GameManager Instance { get; set; } = null;
        #endregion

        #region Public Props
        public UserDataManager userDataManager
        {
            get
            {
                if(_userDataManager == null)
                {
                    _userDataManager = new UserDataManager(this);
                    _userDataManager.Init();
                }

                return _userDataManager;
            }
        }
        public UiManager uiManager
        {
            get
            {
                if(_uiManager == null)
                {
                    _uiManager = new UiManager(this);
                    _uiManager.Init();
                }

                return _uiManager;
            }
        }
       public CursorManager cursorManager
        {
            get
            {
                if (_cursorManager == null) 
                {
                    _cursorManager = new CursorManager(this);
                    _cursorManager.Init();
                }

                return _cursorManager;
            }
        }
        public DatabaseManager databaseManger => _databaseManager;
        #endregion

        #region Private Serialize Fields
        [SerializeField] DatabaseManager _databaseManager;
        [SerializeField] private bool _enableLog;
        #endregion

        #region Private Props
        private UserDataManager _userDataManager { get; set; } = null;
        private UiManager _uiManager { get; set; } = null;
        private CursorManager _cursorManager { get; set; } = null;
        #endregion

        #region Unity Methods
        private void Awake()
        {
            Instance = this;
        }
        private void Start()
        {
            _ = uiManager;
        }
        private void FixedUpdate()
        {
            Debug.unityLogger.logEnabled = _enableLog;
        }
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        #endregion
    }
}
