using BS.Tools;
using DG.Tweening;
using UnityEngine;

namespace BS.Controller
{
    public class LeftToRightDoorController : BaseDoorController
    {
        #region BaseDoorController Props
        public override EDoorType doorType => EDoorType.LeftToRight;
        #endregion
        #region BaseDoorController Methods
        protected override void OnOpen()
        {
            base.OnOpen();

            float endPosition = Mathf.Clamp(_door.position.x + _doorXAxis / 2, _startPosition.x, _startPosition.x + _doorXAxis/2);
            _door.DOMoveX(endPosition, 0.5f);
        }
        protected override void OnClose()
        {
            base.OnClose();

            _door.DOMoveX(_startPosition.x, 0.5f);
        }
        #endregion
    }
}
