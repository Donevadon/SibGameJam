using System.Linq;
using DialogModule.DataBase;
using DialogModule.Panel;

namespace DialogModule.DialogFactories
{
    public class Frame11Factory : FrameFactory
    {
        public Frame11Factory(IDialogPanel panel) : base(panel) {}

        public override SpeechesPack Type { get; } = SpeechesPack.SecondStart;

        protected override ISpeechButton[] CreateButtons()
        {
            return new ISpeechButton[]
            {
                new SpeechButton("Знаете... я вас люблю",
                    ChooseFirstOption),
                new SpeechButton("Вот они",
                    ChooseSecondOption),
                new SpeechButton("Снова съела собака",
                    ChooseThirdOption)
            };
        }
        
        private void ChooseFirstOption()
        {
            ChangeDialog(new Frame20Factory(DialogPanel));
        }
        
        private void ChooseSecondOption()
        {
            ChangeDialog(new Frame12Factory(DialogPanel));
        }

        private void ChooseThirdOption()
        {
            ChangeDialog(new Frame19Factory(DialogPanel));
        }

    }
}