using UnityEngine;

namespace DialogModule.ScriptableObjects
{
    [CreateAssetMenu(fileName = "SpeechPack", menuName = "Speech/SpeechPack", order = 1)]
    public class SpeechPack : ScriptableObject, ISpeechPack
    {
        [SerializeField] private SpeechElement[] elements;
        // ReSharper disable once CoVariantArrayConversion
        public ISpeech[] Speeches => elements;
    }
}
