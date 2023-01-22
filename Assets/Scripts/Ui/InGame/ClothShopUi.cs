using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BS.Ui
{
    public class ClothShopUi : MonoBehaviour
    {
        #region Public Props
        public Action onClickCloseBtnAct { get; set; } = null;
        #endregion

        #region Private Serialize Fields
        [SerializeField] private List<GameObject> _canvasItemList;
        #endregion

        #region Private Props
        private float _fadeTime { get; set; } = 1;
        #endregion

        #region Public Methods
        public void Init()
        {
            Activity(true);
            StartCoroutine("FadeInItems");
        }

        public void Activity(bool pAcitivity)
        {
            gameObject.SetActive(pAcitivity);
        }
        public void OnClickCloseBtn()
        {
            StartCoroutine("FadeOutItems");

            onClickCloseBtnAct?.Invoke();
        }
        #endregion

        #region Private Methods
        private IEnumerator FadeInItems()
        {
            foreach (var item in _canvasItemList)
            {
                item.transform.localScale = Vector3.zero;
            }
            foreach (var item in _canvasItemList)
            {
                item.transform.DOScale(1, _fadeTime).SetEase(Ease.OutBounce);
                yield return new WaitForSeconds(0.2f);
            }
        }
        private IEnumerator FadeOutItems()
        {
            foreach (var item in _canvasItemList)
            {
                item.transform.DOScale(Vector3.zero, 2 * _fadeTime).SetEase(Ease.InBounce);
                yield return new WaitForSeconds(0.2f);
            }
        }
        #endregion
    }
}
