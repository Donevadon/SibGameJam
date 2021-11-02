using UnityEngine.Events;

namespace DialogModule
{
    public interface IButton
    {
        string Text { get; }
        UnityAction Action { get; } 
    }
}