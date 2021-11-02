using UnityEngine;
using UnityEngine.UI;

namespace DialogModule.Panel.NameModule
{
    [RequireComponent(typeof(Text))]
    public class NamePanel : MonoBehaviour, IShowName
    {
        private static Text _text;

        public void ShowName(string speakerName)
        {
            _text.text = speakerName;
        }
        private void Awake()
        {
            _text = GetComponent<Text>();
        }
    }
}