using DialogModule.DataBase;

namespace DialogModule.DialogFactories
{
    internal class Frame15Factory : ErroneousDialogue
    {
        public Frame15Factory(IDialogPanel dialogPanel) : base(dialogPanel) {}

        public override SpeechesPack Type { get; } = SpeechesPack.Frame15;
    }
}