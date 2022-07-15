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

        Debug.Log($"githubRef = {githubRef}");

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