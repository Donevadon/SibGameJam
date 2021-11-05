using DialogModule.DataBase;
using DialogModule.Panel;

namespace DialogModule.DialogFactories
{
    internal class Frame35Factory : FrameFactory
    {
        public Frame35Factory(IDialogPanel dialogPanel) : base(dialogPanel) {}

        public override SpeechesPack Type { get; } = SpeechesPack.Frame35;
        protected override ISpeechButton[] CreateButtons()
        {
            return new ISpeechButton[]
            {
                new SpeechButton("Да",
                    ChooseFirstOption),
                new SpeechButton("Я сомневаюсь",
                    ChooseSecondOption)
            };
        }
        
        private void ChooseFirstOption()
        {
            ChangeDialog(new Frame22Factory(DialogPanel));
        }
        
        private void ChooseSecondOption()
        {
            ChangeDialog(new Frame21Factory(DialogPanel));
        }
    }
}