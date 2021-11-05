using UnityEngine.Events;

namespace DialogModule.Panel
{
    public interface ISpeechButton
    {
        UnityAction Action { get; }
        string Text { get; }
    }
}