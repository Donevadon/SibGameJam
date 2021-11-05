using System.Linq;
using DialogModule.DataBase;
using DialogModule.Panel;

namespace DialogModule.DialogFactories
{
    internal class Frame14Factory : FrameFactory
    {
        public Frame14Factory(IDialogPanel panel) : base(panel) {}

        public override SpeechesPack Type { get; } = SpeechesPack.Frame14;

        protected override ISpeechButton[] CreateButtons()
        {
            return new ISpeechButton[]
            {
                new SpeechButton("Конечно, мисс",
                    ChooseFirstOption),
                new SpeechButton("Я сомневаюсь",
                    ChooseSecondOption),
                new SpeechButton("А вы уверены, что хотите доверить мне это?",
                    ChooseThirdOption)
            };
        }
        
        private void ChooseFirstOption()
        {
            ChangeDialog(new Frame23Factory(DialogPanel));
        }
        
        private void ChooseSecondOption()
        {
            ChangeDialog(new Frame21Factory(DialogPanel));
        }

        private void ChooseThirdOption()
        {
            ChangeDialog(new Frame35Factory(DialogPanel));
        }

    }
}