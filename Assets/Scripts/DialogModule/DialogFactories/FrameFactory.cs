using System.Linq;
using DialogModule.DataBase;
using DialogModule.Panel;

namespace DialogModule.DialogFactories
{
    public abstract class FrameFactory : IDialogFactory
    {
        protected IDialogPanel DialogPanel { get; }
        public abstract SpeechesPack Type { get; }

        protected FrameFactory(IDialogPanel panel)
        {
            DialogPanel = panel;
        }

        public ISpeechPack CreateDialog(ISpeechPack pack)
        {
            var speech = pack.Speeches.Last();
            speech.Buttons = CreateButtons();

            return pack;
        }

        protected abstract ISpeechButton[] CreateButtons();

        protected virtual void ChangeDialog(IDialogFactory factory)
        {
            var dialog = DialogDataBase.LoadDialogs(factory);
            DialogPanel.ShowSpeeches(dialog);
        }
    }
}