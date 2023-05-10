using UnityEditor;
using UnityEngine;

public class BuildScript
{
    public static void Build()
    {
        PlayerSettings.Android.bundleVersionCode = int.Parse(PlayerSettings.bundleVersion);
        PlayerSettings.iOS.buildNumber = PlayerSettings.bundleVersion;
        PlayerSettings.WSA.packageVersion = new System.Version(Application.version);
    }
}
