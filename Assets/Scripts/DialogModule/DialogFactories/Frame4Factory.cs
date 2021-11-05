using System.Linq;
using DialogModule.DataBase;
using DialogModule.Panel;

namespace DialogModule.DialogFactories
{
    internal class Frame4Factory : FrameFactory
    {
        public override SpeechesPack Type { get; } = SpeechesPack.Frame4;
        
        public Frame4Factory(IDialogPanel panel) : base(panel) { }

        protected override ISpeechButton[] CreateButtons()
        {
            return new ISpeechButton[]
            {
                new SpeechButton("Совсем нет, мисс", 
                    ChooseFirstOption),
                new SpeechButton("Да очень хочу",
                    ChooseSecondOption),
                new SpeechButton("Было бы неплохо",
                    ChooseThirdOption)
            };
        }

        private void ChooseFirstOption()
        {
            ChangeDialog(new Frame5Factory(DialogPanel));
        }

        private void ChooseSecondOption()
        {
            ChangeDialog(new Frame7Factory(DialogPanel));
        }
        
        private void ChooseThirdOption()
        {
            ChangeDialog(new Frame6Factory(DialogPanel));
        }
    }
}