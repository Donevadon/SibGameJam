using System.Linq;
using DialogModule.DataBase;
using DialogModule.Panel;

namespace DialogModule.DialogFactories
{
    internal class Frame13Factory : FrameFactory
    {
        public Frame13Factory(IDialogPanel panel) : base(panel) {}

        public override SpeechesPack Type { get; } = SpeechesPack.Frame13;

        protected override ISpeechButton[] CreateButtons()
        {
            return new ISpeechButton[]
            {
                new SpeechButton("Спасибо, мисс",
                    ChooseFirstOption),
                new SpeechButton("Благодарю",
                    ChooseFirstOption),
                new SpeechButton("Рад что вам понравилось",
                    ChooseFirstOption)
            };
        }
        
        private void ChooseFirstOption()
        {
            ChangeDialog(new Frame14Factory(DialogPanel));
        }
    }
}