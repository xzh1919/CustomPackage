using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileHelper
{
    public static string[] GetFiles(string path, string pattern = "*.*", SearchOption option = SearchOption.AllDirectories)
    {
        if (!Directory.Exists(path))
        {
            return new string[] { };
        }

        if (string.IsNullOrEmpty(pattern))
        {
            pattern = "*.*";
        }

        return Directory.GetFiles(path, pattern, option);
    }
}
