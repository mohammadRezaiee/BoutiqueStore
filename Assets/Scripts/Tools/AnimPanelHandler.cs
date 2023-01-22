using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BS.Tools
{
    public class AnimPanelHandler : MonoBehaviour
    {
        #region Private Serialize Fields
        [SerializeField] private List<GameObject> _canvasItemList;
        #endregion

        #region Private Props
        private float _fadeTime { get; set; } = 1;
        #endregion

        #region Private Methods
        private IEnumerator ItemsAnimation()
        {
            foreach(var item in _canvasItemList)
            {
                item.transform.localScale = Vector3.zero;
            }
            foreach(var item in _canvasItemList)
            {
                item.transform.DOScale(1, _fadeTime).SetEase(Ease.OutBounce);
                yield return new WaitForSeconds(0.25f);
            }
        }
        #endregion
    }
}
