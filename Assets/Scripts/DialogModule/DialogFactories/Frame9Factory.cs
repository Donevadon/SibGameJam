using DialogModule.DataBase;

namespace DialogModule.DialogFactories
{
    internal class Frame9Factory : ErroneousDialogue
    {
        public Frame9Factory(IDialogPanel dialogPanel) : base(dialogPanel) {}

        public override SpeechesPack Type { get; } = SpeechesPack.Frame9;
    }
}