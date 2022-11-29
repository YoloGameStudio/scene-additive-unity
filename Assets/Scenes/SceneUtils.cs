using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;

public class SceneUtils
{
    public static void LoadScene(string sceneName, LoadSceneMode mode, Dictionary<string, string> data)
    {
        SceneManager.LoadScene(sceneName, mode);
        SceneData = new Dictionary<string, string>(data);
    }
    public static void UnloadScene(string sceneName, Dictionary<string, string> data)
    {
        SceneManager.UnloadSceneAsync(sceneName);
        SceneData = new Dictionary<string, string>(data);
    }
    
    public static Dictionary<string, string> SceneData = new Dictionary<string, string>();

    public void Clear()
    {
        SceneData.Clear();
    }

    public static string DictToString(Dictionary<string, string> data)
    {
        return data.Aggregate(string.Empty, (current, item) => current + $"[{item.Key} = {item.Value}] ");
    }
}
