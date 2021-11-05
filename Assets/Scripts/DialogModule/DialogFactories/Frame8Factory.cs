using DialogModule.DataBase;

namespace DialogModule.DialogFactories
{
    internal class Frame8Factory : ErroneousDialogue
    {
        public Frame8Factory(IDialogPanel dialogPanel) : base(dialogPanel) {}

        public override SpeechesPack Type { get; } = SpeechesPack.Frame8;
    }
}