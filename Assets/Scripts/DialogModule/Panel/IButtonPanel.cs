namespace DialogModule.Panel
{
    internal interface IButtonPanel
    {
        void SetButtons(ISpeechButton[] buttons);
        void Reset();
    }
}