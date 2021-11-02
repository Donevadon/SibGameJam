using System.Collections;

namespace DialogModule.Panel
{
    /// <summary>
    /// Отображение речи говорящего
    /// </summary>
    public interface IShowText
    {
        /// <summary>
        /// Показать речь говорящего
        /// </summary>
        /// <returns></returns>
        IEnumerator ShowText(string text,float timeBetweenSymbol, float pauseTime);
        void Skip();
    }
}