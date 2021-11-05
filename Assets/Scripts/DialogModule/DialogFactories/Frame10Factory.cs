using DialogModule.DataBase;
using DialogModule.Panel;

namespace DialogModule.DialogFactories
{
    internal class Frame10Factory : FrameFactory
    {
        public Frame10Factory(IDialogPanel dialogPanel) : base(dialogPanel) {}

        public override SpeechesPack Type { get; } = SpeechesPack.Frame10;
        protected override ISpeechButton[] CreateButtons()
        {
            return new ISpeechButton[]
            {
                new SpeechButton("Уже бегу!",
                    DialogPanel.Close)
                ,
                new SpeechButton("Выступаю немедленно",
                    DialogPanel.Close),
            };
        }

    }
}