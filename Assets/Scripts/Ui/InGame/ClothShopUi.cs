using BS.Manager;
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
        [SerializeField] private RawImageUiItem _characterRawImageUiItem;
        [SerializeField] private Transform _characterShowcaseParent;
        #endregion

        #region Private Props
        private GameManager _gameManager => _gameManagerRef != null ? _gameManagerRef : (_gameManagerRef = GameManager.Instance);
        private GameManager _gameManagerRef { get; set; } = null;
        private float _fadeTime { get; set; } = 1;
        private CharacterShowcaseUi _characterShowcaseUi { get; set; } = null;
        #endregion

        #region Public Methods
        public void Init()
        {
            Activity(true);
            GameObject prefab = _gameManager.databaseManger.characterShowcaseUiPrefab;
            _characterShowcaseUi = Instantiate(prefab, _characterShowcaseParent).GetComponent<CharacterShowcaseUi>();
            _characterShowcaseUi.Init();

            _characterRawImageUiItem.SetCam(_characterShowcaseUi.cam);
            StartCoroutine("FadeInItems");
        }

        public void Activity(bool pAcitivity)
        {
            gameObject.SetActive(pAcitivity);
        }
        public void OnClickCloseBtn()
        {
            Destroy(_characterShowcaseUi.gameObject);
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
