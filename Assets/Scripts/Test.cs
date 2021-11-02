using DialogModule;
using DialogModule.DataBase;
using DialogModule.Panel;
using UnityEngine;

public class Test : MonoBehaviour
{
    private DialogPanel _dialogPanel;
    void Start()
    {
        _dialogPanel = FindObjectOfType<DialogPanel>();
        _dialogPanel.ShowSpeeches(DialogDataBase.LoadDialogs(SpeechesPack.Test) as ISpeechPack);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
