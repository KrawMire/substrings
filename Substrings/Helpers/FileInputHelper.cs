using System;
using Substrings.Interfaces;

namespace Substrings.Helpers
{
    public class FileInputHelper : IInputHelper
    {
        private string filePath;

        public FileInputHelper(string path)
        {
            filePath = path;
        }

        public string[] GetStringsArray()
        {
            return File.ReadAllLines(filePath);
        }
    }
}

