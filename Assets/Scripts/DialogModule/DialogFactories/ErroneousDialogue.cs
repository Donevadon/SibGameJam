using System.Linq;
using DialogModule.DataBase;
using DialogModule.Panel;

namespace DialogModule.DialogFactories
{
    public abstract class ErroneousDialogue : IDialogFactory
    {
        private readonly IDialogPanel _dialogPanel;
        
        protected ErroneousDialogue(IDialogPanel panel)
        {
            _dialogPanel = panel;
        }

        public abstract SpeechesPack Type { get; }
        public ISpeechPack CreateDialog(ISpeechPack pack)
        {
            var speech = pack.Speeches.Last();
            speech.Buttons = new ISpeechButton[]
            {
                new SpeechButton("Попробовать ещё раз",
                    ChooseFirstOption)
            };

            return pack;
        }

        private void ChooseFirstOption()
        {
            //TODO: Respawn
            _dialogPanel.Close();
        }
    }
}