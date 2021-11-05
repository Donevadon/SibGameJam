using System.Collections.Generic;
using DialogModule.Panel;
using UnityEngine;

namespace DialogModule.ButtonModule
{
    public class ButtonPanel : MonoBehaviour, IButtonPanel
    {
        private List<DialogButton> _buttons = new List<DialogButton>();
        [SerializeField] private DialogButton promoButton;

        public void SetButtons(ISpeechButton[] buttons)
        {
            _buttons = new List<DialogButton>();
            foreach (var button in buttons)
            {
                var inst = Instantiate(promoButton, transform);
                inst.AddListener(button.Action);
                inst.SetText(button.Text);
                _buttons.Add(inst);
            }
        }

        public void Reset()
        {
            foreach (var button in _buttons) Destroy(button.gameObject);
            _buttons.Clear();
        }
    }
}