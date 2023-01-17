using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BS.Ui
{
    public class WalletUiItem : MonoBehaviour
    {
        #region Private Serialize Fields
        #endregion

        #region Public Props
        public void Init()
        {
            Activity(true);
        }
        public void Activity(bool pActivity)
        {
            gameObject.SetActive(pActivity);
        }
        #endregion
    }
}
