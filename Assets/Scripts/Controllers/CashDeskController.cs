using System;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BS.Ui;

namespace BS.Controller
{
    public class CashDeskController : MonoBehaviour
    {
        #region Public Props
        public Action onClickShopBtnAct { get; set; } = null;
        public Action onClickCloseBtnAct { get; set; } = null;
        #endregion

        #region Private Serialize Fields
        [SerializeField] private GameObject _outlineImg;
        [SerializeField] private Transform _shopBtn;
        [SerializeField] private GameObject _clothShopUiPrefab;
        #endregion

        #region Private Props
        private bool _IsInteractable { get; set; } = false;
        #endregion

        #region Public Methods
        public void OnClickShopBtn()
        {
            _IsInteractable = false;
            ClothShopUi clothShopUi = Instantiate(_clothShopUiPrefab).GetComponent<ClothShopUi>();
            clothShopUi.Init();
            _shopBtn.DOScale(Vector2.zero, 0.2f);
            _outlineImg.SetActive(false);


            onClickShopBtnAct?.Invoke();
        }
        public void OnClickCloseBtn()
        {
            _IsInteractable = true;

            onClickCloseBtnAct?.Invoke();
        }
        #endregion

        #region Unity Methods
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.tag == "Player")
            {
                _shopBtn.DOScale(Vector2.one, 0.2f);
                _outlineImg.SetActive(true);
            }
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            if(collision.tag == "Player")
            {
                _shopBtn.DOScale(Vector2.zero, 0.2f);
                _outlineImg.SetActive(false);
            }
        }
        private void OnTriggerStay2D(Collider2D collision)
        {
            if (collision.tag == "Player" && _IsInteractable == true)
            {
                _shopBtn.DOScale(Vector2.one, 0.2f);
                _outlineImg.SetActive(true);
            }
        }
        #endregion
    }
}
