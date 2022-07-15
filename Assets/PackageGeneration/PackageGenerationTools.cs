using System.IO;
using UnityEditor;
using UnityEngine;

public static class PackageGenerationTools
{
    [MenuItem("Tools/Generate Package")]
    public static void GeneratePackage()
    {
        AssetDatabase.ExportPackage(new string[] {
                "Assets/Audio"
            }, GetPackagePath("Test"), ExportPackageOptions.Recurse);

        Debug.Log("Generating Unity Package Completed");
    }

    private static string GetPackagePath(string title)
    {
        return Path.Combine(
            Path.GetDirectoryName(Directory.GetCurrentDirectory()), "Build",
            $"{title}.{PlayerSettings.bundleVersion}.unitypackage");
    }
}