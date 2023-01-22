using BS.Tools;
using DG.Tweening;
using UnityEngine;

namespace BS.Controller
{
    public class BottomToTopDoorController : BaseDoorController
    {
        #region BaseDoorController Props
        public override EDoorType doorType => EDoorType.BottomToTop;
        #endregion
        #region BaseDoorController Methods
        protected override void OnOpen()
        {
            base.OnOpen();

            float endPosition = Mathf.Clamp(_door.position.y + _doorYAxis / 2, _startPosition.y, _startPosition.y + _doorYAxis / 2);
            _door.DOMoveY(endPosition, 0.5f);
        }
        protected override void OnClose()
        {
            base.OnClose();

            _door.DOMoveY(_startPosition.y, 0.5f);
        }
        #endregion
    }
}