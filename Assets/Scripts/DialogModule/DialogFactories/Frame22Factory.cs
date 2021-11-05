using System;
using DialogModule.DataBase;
using DialogModule.Panel;

namespace DialogModule.DialogFactories
{
    internal class Frame22Factory : FrameFactory
    {
        public Frame22Factory(IDialogPanel dialogPanel) : base(dialogPanel) {}

        public override SpeechesPack Type { get; } = SpeechesPack.Frame22;
        
        protected override ISpeechButton[] CreateButtons()
        {
            return Array.Empty<ISpeechButton>();
        }
    }
}