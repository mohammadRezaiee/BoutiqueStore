using System;

namespace BS.Manager
{
    [Serializable]
    public class UserDataManager
    {
        #region Private Props
        private GameManager _gameManger;
        #endregion

        #region Constructor
        public UserDataManager(GameManager pGameManager)
        {
            _gameManger = pGameManager;
        }
        #endregion

        #region Public Methods
        public void Init()
        {

        }
        #endregion
    }
}
