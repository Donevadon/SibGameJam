using System;
using DialogModule.DataBase;
using DialogModule.Panel;

namespace DialogModule.DialogFactories
{
    internal class Frame23Factory : FrameFactory
    {
        public Frame23Factory(IDialogPanel dialogPanel) : base(dialogPanel) {}
        public override SpeechesPack Type { get; } = SpeechesPack.Frame23;
        protected override ISpeechButton[] CreateButtons()
        {
            return Array.Empty<ISpeechButton>();
        }
    }
}