using DialogModule.Panel;
using UnityEngine;

namespace DialogModule
{
    public interface ISpeech
    {
        string Name { get; }
        string Speech { get; }
        Sprite Speaker { get; }
        ISpeechButton[] Buttons { get; set; }
    }
}