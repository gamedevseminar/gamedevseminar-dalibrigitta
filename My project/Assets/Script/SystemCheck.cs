using UnityEngine;
using System.IO;

public class SystemCheck : MonoBehaviour
{
    void Start()
    {
        // 1. Gather Data
        string content = "--- UNITY SETUP PROOF ---\n";
        content += $"Unity Version: {Application.unityVersion}\n";
        content += $"OS: {SystemInfo.operatingSystem}\n";
        content += $"Device: {SystemInfo.deviceName}\n";
        content += $"GPU: {SystemInfo.graphicsDeviceName}\n";
        content += "-------------------------";

        // 2. Write to file (Saved in the project root, next to Assets)
        string path = Path.Combine(Application.dataPath, "../proof.txt");
        File.WriteAllText(path, content);

        Debug.Log("✅ Proof generated at: " + path);
    }
}
