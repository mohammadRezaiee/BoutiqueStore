using System;
using UnityEngine;

namespace BS.Ui
{
    public class GeneralButtonsUi : MonoBehaviour
    {
        #region Public Props
        public Action onClickExitBtnAct { get; set; } = null;
        #endregion

        #region Public Methods
        public void Init()
        {
            Activity(true);
        }
        public void Activity(bool pActivity)
        {
            gameObject.SetActive(pActivity);
        }
        public void OnClickExitBtn()
        {
            Application.Quit();

            onClickExitBtnAct?.Invoke();
        }
        #endregion
    }
}
