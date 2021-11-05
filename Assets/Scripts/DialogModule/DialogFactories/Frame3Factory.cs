using DialogModule.DataBase;

namespace DialogModule.DialogFactories
{
    internal class Frame3Factory : ErroneousDialogue
    {
        public Frame3Factory(IDialogPanel panel) : base(panel)
        {
        }

        public override SpeechesPack Type { get; } = SpeechesPack.Frame3;
    }
}