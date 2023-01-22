using BS.Manager;
using BS.Tools;
using UnityEngine;
using UnityEngine.Events;

namespace BS.Controller
{
    public class CustomButtonController : MonoBehaviour
    {
        #region Public Props
        public UnityEvent onMouseEnter;
        public UnityEvent onMouseExit;
        public UnityEvent onMouseDown;
        public UnityEvent onMouseUp;
        #endregion

        #region Private Serialize Props
        [SerializeField] private Sprite _btnSprite;
        [SerializeField] private Sprite _btnSpritePressed;
        [SerializeField] private SpriteRenderer _btnImg;
        [SerializeField] private Transform _btnContent;
        #endregion

        #region Private Props
        private float _startYpos { get; set; } = 0;
        #endregion

        #region Unity Methods
        private void Start()
        {
            _startYpos = _btnContent.transform.localPosition.y;
        }
        #endregion

        #region Private Methods
        private void OnMouseEnter()
        {
            GameManager.Instance.cursorManager.SetCursorState(ECursorType.Hover);

            onMouseEnter?.Invoke();
        }

        private void OnMouseExit()
        {
            GameManager.Instance.cursorManager.SetCursorState(ECursorType.Default);

            onMouseExit?.Invoke();
        }

        private void OnMouseDown()
        {         
            _btnContent.localPosition = Vector2.zero;
            _btnImg.sprite = _btnSpritePressed;

            onMouseDown?.Invoke();
        }

        private void OnMouseUp()
        {
            _btnContent.localPosition = new Vector2(0, _startYpos);
            _btnImg.sprite = _btnSprite;

            onMouseUp?.Invoke();
        }
        #endregion
    }
}
