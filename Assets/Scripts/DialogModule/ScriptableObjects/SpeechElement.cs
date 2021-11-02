using UnityEngine;

namespace DialogModule.ScriptableObjects
{
    [CreateAssetMenu(fileName = "Speech", menuName = "Speech/SpeechElement", order = 1)]
    public class SpeechElement : ScriptableObject, ISpeech
    {
        [SerializeField] private string speakerName;
        [SerializeField] private string speech;
        [SerializeField] private Sprite speaker;

        public string Name => speakerName;
        public string Speech => speech;
        public Sprite Speaker => speaker;
        public IButton[] Buttons { get; }
    }
}
