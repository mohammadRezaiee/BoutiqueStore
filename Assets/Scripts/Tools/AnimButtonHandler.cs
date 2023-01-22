using BS.Manager;
using BS.Tools;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace BS.Ui
{
    [RequireComponent(typeof(Button))]
    public class AnimButtonHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
    {
        #region Public Props
        public UnityEvent onPointerDown;
        public UnityEvent onPointerUp;
        public UnityEvent onPointerEnter;
        public UnityEvent onPointerExit;
        public UnityEvent whilePointerPressed;
        #endregion

        #region Private Serialize Fields
        [SerializeField] private Sprite _btnSprite;
        [SerializeField] private Sprite _btnSpritePressed;
        [SerializeField] private Image _btnImg;
        [SerializeField] private Transform _btnContent;
        #endregion

        #region Private Props
        private Button _button { get; set; } = null;
        private float _startYpos { get; set; } = 0;
        #endregion

        #region Unity Methods
        private void Awake()
        {
            _button = GetComponent<Button>();
            _startYpos = _btnContent.transform.localPosition.y;
        }
        #endregion

        #region Public Listeners
        public void OnPointerDown(PointerEventData eventData)
        {
            if (!_button.interactable) return;
            StopAllCoroutines();
            StartCoroutine(WhilePressed());
            _btnContent.localPosition = Vector2.zero;
            _btnImg.sprite = _btnSpritePressed;

            onPointerDown?.Invoke();
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            StopAllCoroutines();
            GameManager.Instance.cursorManager.SetCursorState(ECursorType.Hover);

            onPointerEnter?.Invoke();
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            StopAllCoroutines();
            GameManager.Instance.cursorManager.SetCursorState(ECursorType.Default);

            onPointerExit?.Invoke();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            StopAllCoroutines();
            _btnContent.localPosition = new Vector2(0, _startYpos);
            _btnImg.sprite = _btnSprite;

            onPointerUp?.Invoke();
        }
        #endregion

        #region Private Methods
        private IEnumerator WhilePressed()
        {
            while (true)
            {
                whilePointerPressed?.Invoke();
                yield return null;
            }
        }
        #endregion
    }
}
