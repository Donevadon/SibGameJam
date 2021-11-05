using DialogModule.DataBase;

namespace DialogModule.DialogFactories
{
    internal class Frame21Factory : ErroneousDialogue
    {
        public Frame21Factory(IDialogPanel dialogPanel) : base(dialogPanel)
        {}

        public override SpeechesPack Type { get; } = SpeechesPack.Frame21;
    }
}