using System;
using System.IO;
using UnityEditor;
using UnityEngine;

public static class PackageGenerationTools
{
    [MenuItem("Tools/Generate Package")]
    public static void GeneratePackage()
    {
        var githubRef = Environment.GetEnvironmentVariable("GITHUB_REF");

        if (githubRef != null)
            PlayerSettings.bundleVersion = githubRef.Substring(11);

        Debug.Log($"githubRef : {githubRef}");
        Debug.Log($"bundleVersion : {PlayerSettings.bundleVersion}");

        AssetDatabase.ExportPackage(new string[] {
                "Assets/Audio"
            }, GetPackagePath("Test"), ExportPackageOptions.Recurse);

        Debug.Log("Generating Unity Package Completed");
    }

    private static string GetPackagePath(string title)
    {
        return Path.Combine("build",
            $"{title}.{PlayerSettings.bundleVersion}.unitypackage");
    }
}