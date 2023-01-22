using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BS.Tools;

namespace BS.Controller
{
    [RequireComponent(typeof(BoxCollider2D))]
    public abstract class BaseDoorController : MonoBehaviour
    {
        #region Public Props
        public virtual EDoorType doorType { get; }
        #endregion

        #region proteced Props
        protected float _doorXAxis { get; set; } = 0;
        protected float _doorYAxis { get; set; } = 0;
        protected Vector2 _startPosition { get; set; } = Vector2.zero; 
        #endregion

        #region Protected Serialize Fields
        [SerializeField] protected Transform _door;
        #endregion

        #region Private Props
        private BoxCollider2D _doorCollider { get; set; } = null;
        private bool _tryOpen { get; set; } = false;
        #endregion

        #region Unity Methods
        private void Start()
        {
            _doorCollider = GetComponentInChildren<BoxCollider2D>();

            _doorXAxis = _doorCollider.size.x;
            _doorYAxis = _doorCollider.size.y;
            _startPosition = _door.transform.position;
        }
        #endregion

        #region Protected Methods
        protected virtual void OnOpen()
        {
            
        }
        protected virtual void OnClose()
        {

        }
        #endregion

        #region Private Methods
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.tag == "Player")
            {
                _tryOpen = true;
                OnOpen();
            }
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            if(collision.tag == "Player")
            {
                _tryOpen = false;
                OnClose();
            }
        }
        #endregion
    }
}
