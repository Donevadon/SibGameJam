using System;
using UnityEngine;

namespace DialogModule.DataBase
{
    public static class DialogDataBase
    {
        public static ISpeechPack LoadDialogs(IDialogFactory factory)
        {
            var pack = Load(factory.Type);
            return factory.CreateDialog(pack);
        }

        private static ISpeechPack Load(SpeechesPack type)
        {
            var str = $"SpeechesPacks/{(int)type}";
            return Resources.Load(str) as ISpeechPack ?? throw new NullReferenceException("Speech pack not found");
        }
    }

    public enum SpeechesPack : int
    {
        FirstStart = 1,
        Frame2,
        Frame3,
        Frame4,
        Frame5,
        Frame6,
        Frame7,
        Frame8,
        Frame9,
        Frame10,
        SecondStart,
        Frame12,
        Frame13,
        Frame14,
        Frame15,
        Frame16,
        Frame17,
        Frame18,
        Frame19,
        Frame20,
        Frame21,
        Frame22,
        Frame23,
        Frame24,
        Frame25,
        Frame26,
        Frame27,
        Frame28,
        Frame29,
        Frame30,
        Frame31,
        Frame32,
        Frame33,
        Frame34,
        Frame35,
        Frame36,
        Frame37,
        Frame38,
        Frame39
    }
}