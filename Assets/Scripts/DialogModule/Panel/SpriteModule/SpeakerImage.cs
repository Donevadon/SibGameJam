using UnityEngine;
using UnityEngine.UI;

namespace DialogModule.Panel.SpriteModule
{
    [RequireComponent(typeof(Image))]
    public class SpeakerImage :MonoBehaviour, ISpeechImage
    {
        private Image _image;

        private void Awake()
        {
            _image = GetComponent<Image>();
        }

        public void SetSprite(Sprite speechSpeaker)
        {
            _image.sprite = speechSpeaker;
        }
    }
}