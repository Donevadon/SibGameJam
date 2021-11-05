using DialogModule.DataBase;

namespace DialogModule.DialogFactories
{
    internal class Frame2Factory : ErroneousDialogue
    {
        public Frame2Factory(IDialogPanel panel) : base(panel)
        {
        }

        public override SpeechesPack Type { get; } = SpeechesPack.Frame2;
    }
}