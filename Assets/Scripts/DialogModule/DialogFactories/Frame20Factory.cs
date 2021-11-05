using DialogModule.DataBase;

namespace DialogModule.DialogFactories
{
    internal class Frame20Factory : ErroneousDialogue
    {
        public Frame20Factory(IDialogPanel dialogPanel) : base(dialogPanel) {}

        public override SpeechesPack Type { get; } = SpeechesPack.Frame20;
    }
}