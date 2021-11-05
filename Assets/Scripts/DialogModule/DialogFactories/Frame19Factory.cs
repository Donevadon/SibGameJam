using DialogModule.DataBase;

namespace DialogModule.DialogFactories
{
    internal class Frame19Factory : ErroneousDialogue
    {
        public Frame19Factory(IDialogPanel dialogPanel) : base(dialogPanel)
        {}

        public override SpeechesPack Type { get; } = SpeechesPack.Frame19;
    }
}