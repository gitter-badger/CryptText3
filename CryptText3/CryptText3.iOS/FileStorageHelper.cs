﻿using System;
using System.IO;
using CryptText3.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileStorageHelper))]

namespace CryptText3.iOS
{
    internal class FileStorageHelper : IFileStorage
    {
        public void SaveText(string filename, string text)
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, filename);
            File.WriteAllText(filePath, text);
        }

        public string LoadText(string filename)
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, filename);
            return File.ReadAllText(filePath);
        }

        public bool FileExists(string filename)
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, filename);
            return File.Exists(filePath);
        }
    }
}