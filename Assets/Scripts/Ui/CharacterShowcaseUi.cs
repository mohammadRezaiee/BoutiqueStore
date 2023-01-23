using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BS.Ui
{
    public class CharacterShowcaseUi : MonoBehaviour
    {
        #region Public Serialize Fields
        [field: SerializeField] public Camera cam { get; private set; } = null;
        #endregion

        #region Private Serialize Fields
        [SerializeField] private SpriteRenderer _characterRenderer;
        [SerializeField] private Transform _character;
        #endregion

        #region Unity Methods
        private void OnDestroy()
        {
            
        }
        #endregion

        #region Public Methods
        public void Init()
        {
            cam.gameObject.SetActive(true);
        }
        #endregion
    }
}
