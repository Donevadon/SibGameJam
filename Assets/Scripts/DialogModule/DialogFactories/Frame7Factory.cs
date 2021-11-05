using DialogModule.DataBase;
using DialogModule.Panel;

namespace DialogModule.DialogFactories
{
    internal class Frame7Factory : FrameFactory
    {
        public Frame7Factory(IDialogPanel dialogPanel) : base(dialogPanel)
        {}

        public override SpeechesPack Type { get; } = SpeechesPack.Frame7;
        protected override ISpeechButton[] CreateButtons()
        {
            return new ISpeechButton[]
            {
                new SpeechButton("Вот они мисс",
                    ChooseFirstOption),
                new SpeechButton("*Искать отчёты в портфеле*",
                    ChooseSecondOption),
                new SpeechButton("Отчёты съела собака",
                    ChooseThirdOption)
            };
        }
        
        private void ChooseFirstOption()
        {
            ChangeDialog(new Frame8Factory(DialogPanel));
        }

        private void ChooseSecondOption()
        {
            ChangeDialog(new Frame9Factory(DialogPanel));
        }
        
        private void ChooseThirdOption()
        {
            ChangeDialog(new Frame10Factory(DialogPanel));
        }

    }
}