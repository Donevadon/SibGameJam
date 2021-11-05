using DialogModule.DataBase;
using DialogModule.DialogFactories;
using DialogModule.Panel;
using UnityEngine;

public class Test : MonoBehaviour
{
    private DialogPanel _dialogPanel;

    void Start()
    {
        _dialogPanel = FindObjectOfType<DialogPanel>();
        var pack = DialogDataBase.LoadDialogs(new Frame11Factory(_dialogPanel));
        _dialogPanel.ShowSpeeches(pack);
    }
}