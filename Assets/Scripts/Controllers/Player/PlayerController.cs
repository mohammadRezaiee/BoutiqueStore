using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace BS.Controller
{
    public class PlayerController : MonoBehaviour
    {
        #region Private Serialize Fields
        [SerializeField] private float _moveSpeed = 1f;
        [SerializeField] private float _collisionOffset = 0.05f;
        [SerializeField] private ContactFilter2D _movementFilter;
        #endregion

        #region Private Props
        private Vector2 _movementInput { get; set; } = Vector2.zero;
        private Rigidbody2D _playarRigidbody { get; set; } = null;
        private List<RaycastHit2D> _castCollision { get; set; } = new List<RaycastHit2D>();
        #endregion

        #region Unity Methods
        private void Start()
        {
            _playarRigidbody = GetComponent<Rigidbody2D>();
        }
        private void FixedUpdate()
        {
            if(_movementInput != Vector2.zero)
            {
                bool success = TryMove(_movementInput);

                if (!success)
                {
                    success = TryMove(new Vector2(_movementInput.x, 0));

                    if (!success)
                    {
                        success = TryMove(new Vector2(0, _movementInput.y));
                    }
                }
            }
        }
        #endregion

        #region Private Methods
        private void OnMove(InputValue pMovementValue)
        {
            _movementInput = pMovementValue.Get<Vector2>();
        }
        private bool TryMove(Vector2 pDirection)
        {
            if (pDirection != Vector2.zero)
            {
                int count = _playarRigidbody.Cast(
                        pDirection,
                        _movementFilter,
                        _castCollision,
                        _moveSpeed * Time.fixedDeltaTime + _collisionOffset);

                if (count == 0)
                {
                    _playarRigidbody.MovePosition(_playarRigidbody.position + pDirection * _moveSpeed * Time.deltaTime);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
