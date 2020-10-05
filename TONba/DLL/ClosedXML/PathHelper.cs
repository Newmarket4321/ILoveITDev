// Decompiled with JetBrains decompiler
// Type: ClosedXML.PathHelper
// Assembly: ClosedXML, Version=0.76.0.0, Culture=neutral, PublicKeyToken=fd1eb21b62ae805b
// MVID: 637E6F67-8B3B-428A-80E9-7ACAE73D138B
// Assembly location: C:\Users\graeme smyth\Documents\Visual Studio 2015\Projects\I❤IT\I❤IT\bin\Debug\ClosedXML.dll

using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace ClosedXML
{
  internal static class PathHelper
  {
    private static readonly Regex ms_checkValidAbsolutePathRegEx = new Regex("^(([a-zA-Z]\\:)|\\\\)(\\\\|(\\\\[^\\n\\r\\t/:*?<>\\\"|]*)+)$", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.CultureInvariant);
    private static readonly Regex ms_checkValidRelativePathRegEx = new Regex("^(\\.\\.|\\.)(\\\\|(\\\\[^\\n\\r\\t/:*?<>\\\"|]*)+)$", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Compiled | RegexOptions.CultureInvariant);
    private static readonly object ms_syncAbsolutePathObj = new object();

    public static string GetTimeStamp()
    {
      return PathHelper.GetTimeStamp(DateTime.Now);
    }

    public static string GetTimeStamp(DateTime dateTime)
    {
      return dateTime.ToString("ddMMMyyyy_HHmmss", (IFormatProvider) DateTimeFormatInfo.InvariantInfo);
    }

    public static void SafetyDeleteFile(string fileName)
    {
      try
      {
        if (string.IsNullOrEmpty(fileName) || !File.Exists(fileName))
          return;
        File.Delete(fileName);
      }
      catch (Exception ex)
      {
      }
    }

    public static string NormalizeFileName(string fileName)
    {
      char[] invalidFileNameChars = Path.GetInvalidFileNameChars();
      string str = fileName.TrimStart(' ');
      if (str.Length < fileName.Length)
        str = new string('_', fileName.Length - str.Length) + str;
      foreach (char oldChar in invalidFileNameChars)
        str = str.Replace(oldChar, '_');
      return str;
    }

    public static string NormalizePathName(string fileName)
    {
      char[] invalidPathChars = Path.GetInvalidPathChars();
      string str = fileName.TrimStart(' ');
      foreach (char oldChar in invalidPathChars)
        str = str.Replace(oldChar, '_');
      return str;
    }

    public static bool ValidatePath(string path, PathHelper.PathTypes type)
    {
      bool flag = false;
      if ((type & PathHelper.PathTypes.Absolute) == PathHelper.PathTypes.Absolute)
        flag |= PathHelper.ms_checkValidAbsolutePathRegEx.IsMatch(path);
      if ((type & PathHelper.PathTypes.Relative) == PathHelper.PathTypes.Relative)
        flag |= PathHelper.ms_checkValidRelativePathRegEx.IsMatch(path);
      return flag;
    }

    public static bool ValidateFileName(string fileName)
    {
      return fileName.LastIndexOfAny(Path.GetInvalidFileNameChars()) < 0;
    }

    public static string EvaluateRelativePath(string mainDirPath, string absoluteFilePath)
    {
      string[] strArray1 = mainDirPath.Trim(Path.DirectorySeparatorChar).Split(Path.DirectorySeparatorChar);
      string[] strArray2 = absoluteFilePath.Trim(Path.DirectorySeparatorChar).Split(Path.DirectorySeparatorChar);
      int num1 = 0;
      int num2 = Math.Min(strArray1.Length, strArray2.Length);
      for (int index = 0; index < num2 && string.Compare(strArray1[index], strArray2[index], true) == 0; ++index)
        ++num1;
      if (num1 == 0)
        return absoluteFilePath;
      string str = string.Empty;
      for (int index = num1; index < strArray1.Length; ++index)
      {
        if (index > num1)
          str += (string) (object) Path.DirectorySeparatorChar;
        str += "..";
      }
      if (str.Length == 0)
        str = ".";
      for (int index = num1; index < strArray2.Length; ++index)
        str = str + (object) Path.DirectorySeparatorChar + strArray2[index];
      return str;
    }

    public static string EvaluateAbsolutePath(string rootPath, string relativePath)
    {
      lock (PathHelper.ms_syncAbsolutePathObj)
      {
        string currentDirectory = Environment.CurrentDirectory;
        Environment.CurrentDirectory = rootPath;
        string fullPath = Path.GetFullPath(relativePath);
        Environment.CurrentDirectory = currentDirectory;
        return fullPath;
      }
    }

    public static bool TryCreateFile(string filePath, out string message)
    {
      if (string.IsNullOrEmpty(filePath))
        throw new ArgumentNullException(nameof (filePath));
      try
      {
        if (File.Exists(filePath))
        {
          message = (string) null;
          return true;
        }
        using (new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite, FileShare.Read, 1024, FileOptions.DeleteOnClose))
          ;
      }
      catch (Exception ex)
      {
        message = ex.Message;
        return false;
      }
      message = (string) null;
      return true;
    }

    public static string CreateDirectory(string path)
    {
      try
      {
        DirectoryInfo directoryInfo = new DirectoryInfo(path);
        if (!directoryInfo.Exists)
          directoryInfo.Create();
      }
      catch
      {
      }
      return path;
    }

    [Flags]
    public enum PathTypes
    {
      None = 0,
      Absolute = 1,
      Relative = 2,
    }
  }
}
