using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace DialogModule.Panel
{
    public class DialogPanel : MonoBehaviour, IDialogPanel
    {
        private IShowName _showName;
        private IShowText _showText;
        private ISpeechImage _imageSpeaker;
        private IButtonPanel _buttonPanel;
        private Coroutine _showSpeechesCoroutine;
        [SerializeField] private float printingSpeed;
        [SerializeField] private float pauseTime;

        private void Awake()
        {
            _showName = GetComponentInChildren<IShowName>() ?? throw new Exception("ShowName not found");
            _showText = GetComponentInChildren<IShowText>() ?? throw new Exception("ShowText not found");
            _imageSpeaker = GetComponentInChildren<ISpeechImage>() ?? throw new Exception("SpeechImage not found");
            _buttonPanel = GetComponentInChildren<IButtonPanel>() ?? throw new Exception("ButtonPanel not found");
        }

        public void ShowSpeeches(ISpeechPack pack)
        {
            _buttonPanel.Reset();
            _showSpeechesCoroutine = StartCoroutine(StartShowSpeeches(pack));
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        private IEnumerator StartShowSpeeches(ISpeechPack pack)
        {
            foreach (var speech in pack.Speeches)
            {
                _showName.ShowName(speech.Name);
                _imageSpeaker.SetSprite(speech.Speaker);
                yield return _showText.ShowText(speech.Speech, printingSpeed, pauseTime);
                _buttonPanel.SetButtons(speech.Buttons);
            }
        }
    }
}