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
        SceneUtils.UnloadScene("Scene2", new Dictionary<string, string>()
        {
            {"field4", "value4"},
            {"field5", "value5"},
            {"field6", "value6"},
        });
    }
}
