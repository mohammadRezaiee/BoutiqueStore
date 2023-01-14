using BS.Manager;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BS.Ui
{
    public class CalenderUiItem : MonoBehaviour
    {
        #region Private Serialize Fields
        [SerializeField] private TMP_Text _dayName;
        [SerializeField] private TMP_Text _dayNum;
        [SerializeField] private TMP_Text _seasonName;
        [SerializeField] private TMP_Text _timeLbl;
        [SerializeField] private Image _wheaterImg;
        #endregion

        #region Private Props
        private GameManager _gameManaer => _gameManagerRef != null ? _gameManagerRef : (_gameManagerRef = GameManager.Instance);
        private GameManager _gameManagerRef { get; set; } = null;
        #endregion

        #region Public Methods
        public void Init()
        {

        }
        #endregion
    }
}
