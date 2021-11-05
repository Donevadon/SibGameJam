using System.Linq;
using DialogModule.DataBase;
using DialogModule.Panel;

namespace DialogModule.DialogFactories
{
    public class Frame1Factory : FrameFactory
    {
        public Frame1Factory(IDialogPanel panel) : base(panel) {}

        public override SpeechesPack Type { get; } = SpeechesPack.FirstStart;

        protected override ISpeechButton[] CreateButtons()
        {
            return new ISpeechButton[]
            {
                new SpeechButton("Прошу извините меня, этого больше не повторится",
                    ChooseFirstOption),
                new SpeechButton("Конечно дорожу!",
                    ChooseSecondOption),
                new SpeechButton("Вы выглядите сегодня потрясающе!",
                    ChooseThirdOption)
            };
        }
        
        private void ChooseFirstOption()
        {
            ChangeDialog(new Frame3Factory(DialogPanel));
        }
        
        private void ChooseSecondOption()
        {
            ChangeDialog(new Frame4Factory(DialogPanel));
        }

        private void ChooseThirdOption()
        {
            ChangeDialog(new Frame2Factory(DialogPanel));
        }

    }
}