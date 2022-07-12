using System;
namespace Substrings.Interfaces
{
    /// <summary>
    /// Interface mainly used to get strings array, in this project
    /// the console input is used. But it can be, for example, text document
    /// input or downloading strings array from cloud services
    /// </summary>
    public interface IInputHelper
    {
        public string[] GetStringsArray();
    }
}

