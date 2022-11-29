# Installation

Copy the file `Assets/Scenes/SceneUtils.cs` to your project

# Example

On some controller of scene1
```
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExampleScene1 : MonoBehaviour
{
    private void OnEnable()
    {
        // Register scene unload event
        SceneManager.sceneUnloaded += OnSceneUnloaded;
    }

    private void OnDisable()
    {
        // Unregister scene unload event
        SceneManager.sceneUnloaded -= OnSceneUnloaded;
    }
    
    private void OnSceneUnloaded(Scene scene)
    {
        //
        Debug.Log($"<color=yellow>{scene.name} unloaded with data {SceneUtils.DictToString(SceneUtils.SceneData)}</color>");
    }

    public void LoadScene2()
    {
        // Use this method to load the scene 2
        SceneUtils.LoadScene("Scene2", LoadSceneMode.Additive, new Dictionary<string, string>()
        {
            {"field1", "value1"},
            {"field2", "value2"},
            {"field3", "value3"},
        });
    }
}

```

On some controller of scene 2

```
using System.Collections.Generic;
using UnityEngine;

public class ExampleScene2 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log($"<color=cyan>Receive data: {SceneUtils.DictToString(SceneUtils.SceneData)}</color>");
    }

    public void CloseScene()
    {
        // Use this method to unload the scene 2
        SceneUtils.UnloadScene("Scene2", new Dictionary<string, string>()
        {
            {"field4", "value4"},
            {"field5", "value5"},
            {"field6", "value6"},
        });
    }
}
```

