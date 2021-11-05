using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace DialogModule.ButtonModule
{
    public class DialogButton : MonoBehaviour
    {
        private Button _button;
        private Text _text;

        private void Awake()
        {
            _button = GetComponent<Button>();
            _text = GetComponentInChildren<Text>();
        }

        public void AddListener(UnityAction action)
        {
            _button.onClick.AddListener(action);
        }

        public void SetText(string text)
        {
            _text.text = text;
        }
    }
}