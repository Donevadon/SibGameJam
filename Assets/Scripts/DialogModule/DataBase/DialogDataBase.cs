using UnityEngine;

namespace DialogModule.DataBase
{
    public static class DialogDataBase
    {
        public static object LoadDialogs(SpeechesPack pack)
        {
            var str = $"SpeechesPacks/{pack}";
            var result = Resources.Load(str);
            return result;
        }
    }
    
    public enum SpeechesPack
    {
        Test = 0
    }
}