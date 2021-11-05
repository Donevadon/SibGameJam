namespace DialogModule.DataBase
{
    public interface IDialogFactory
    {
        SpeechesPack Type { get; }
        ISpeechPack CreateDialog(ISpeechPack pack);
    }
}