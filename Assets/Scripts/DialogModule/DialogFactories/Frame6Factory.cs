using DialogModule.DataBase;

namespace DialogModule.DialogFactories
{
    internal class Frame6Factory : ErroneousDialogue
    {
        public Frame6Factory(IDialogPanel dialogPanel) : base(dialogPanel) {}

        public override SpeechesPack Type { get; } = SpeechesPack.Frame6;
    }
}