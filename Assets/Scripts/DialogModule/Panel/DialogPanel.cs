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
        private Coroutine _showSpeechesCoroutine;
        [SerializeField] private Transform buttonPanel;
        [SerializeField] private Image imageSpeaker;
        [SerializeField] private float printingSpeed;
        [SerializeField] private float pauseTime;

        private void Awake()
        {
            _showName = GetComponentInChildren<IShowName>() ?? throw new Exception("ShowName not found");
            _showText = GetComponentInChildren<IShowText>() ?? throw new Exception("ShowText not found");
        }

        public void ShowSpeeches(ISpeechPack pack)
        {
            _showSpeechesCoroutine = StartCoroutine(StartShowSpeeches(pack));
        }

        private IEnumerator StartShowSpeeches(ISpeechPack pack)
        {
            foreach (var speech in pack.Speeches)
            {
                _showName.ShowName(speech.Name);
                yield return _showText.ShowText(speech.Speech, printingSpeed, pauseTime);
            }
        }
    }
}