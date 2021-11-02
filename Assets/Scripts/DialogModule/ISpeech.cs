using UnityEngine;

namespace DialogModule
{
    public interface ISpeech
    {
        string Name { get; }
        string Speech { get; }
        Sprite Speaker { get; }
        IButton[] Buttons { get; }
    }
}