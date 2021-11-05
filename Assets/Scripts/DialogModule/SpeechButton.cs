using DialogModule.Panel;
using UnityEngine.Events;

namespace DialogModule
{
    public class SpeechButton : ISpeechButton
    {
        public UnityAction Action { get; }
        public string Text { get; }

        public SpeechButton(string text, UnityAction action)
        {
            Action = action;
            Text = text;
        }
    }
}