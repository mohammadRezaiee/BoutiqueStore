using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BS.Ui
{
    public class RawImageUiItem : MonoBehaviour
    {
        #region Private Serialize Fields
        [SerializeField] private RectTransform _rawImageRct;
        #endregion

        #region Private Props
        private Camera _cam { get; set; } = null;
        #endregion

        #region Public Methods
        public void SetCam(Camera pCam)
        {
            _cam = pCam;
            _cam.aspect = _rawImageRct.rect.width / _rawImageRct.rect.height;
            _cam.Render();
        }
        #endregion
    }
}