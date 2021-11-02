using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace DialogModule.Panel.TextModule
{
    public class SpeakerPanel : MonoBehaviour, IShowText
    {
        private Text _textOut;
        private string _text;
        private bool _skip;

        /// <summary>
        /// Запись текста для дальнейшего отображения
        /// </summary>
        /// <param name="text"></param>
        public SpeakerPanel(string text)
        {
            _text = text;
        }

        public IEnumerator ShowText(string text, float printingSpeed, float pauseTime)
        {
            yield return new WaitForEndOfFrame();
            _textOut.text = "";
            _skip = false;
            foreach (var c in text)
            {
                if (_skip)
                {
                    _textOut.text = text;
                    break;
                }
                _textOut.text += c;
                yield return new WaitForSeconds(printingSpeed);
            }
            yield return new WaitForSeconds(pauseTime);
        }

        public void Skip()
        {
            _skip = true;
        }

        private void Awake()
        {
            _textOut = GetComponent<Text>();
        }
    }
}