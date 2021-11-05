using System.Linq;
using DialogModule.DataBase;
using DialogModule.Panel;

namespace DialogModule.DialogFactories
{
    internal class Frame12Factory : FrameFactory
    {
        public Frame12Factory(IDialogPanel panel) : base(panel) {}

        public override SpeechesPack Type { get; } = SpeechesPack.Frame12;

        protected override ISpeechButton[] CreateButtons()
        {
            return new ISpeechButton[]
            {
                new SpeechButton("Да, мисс",
                    ChooseFirstOption),
                new SpeechButton("Чуть меньше",
                    ChooseFirstOption),
                new SpeechButton("Вообще-то пол года",
                    ChooseThirdOption)
            };
        }

        private void ChooseFirstOption()
        {
            ChangeDialog(new Frame13Factory(DialogPanel));
        }

        private void ChooseThirdOption()
        {
            ChangeDialog(new Frame15Factory(DialogPanel));
        }
    }
}