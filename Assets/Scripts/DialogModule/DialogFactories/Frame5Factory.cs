using DialogModule.DataBase;

namespace DialogModule.DialogFactories
{
    internal class Frame5Factory : ErroneousDialogue
    {
        public Frame5Factory(IDialogPanel panel) : base(panel) {}

        public override SpeechesPack Type { get; } = SpeechesPack.Frame5;
    }
}