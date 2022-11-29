using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExampleScene1 : MonoBehaviour
{
    private void OnEnable()
    {
        SceneManager.sceneUnloaded += OnSceneUnloaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneUnloaded -= OnSceneUnloaded;
    }
    
    private void OnSceneUnloaded(Scene scene)
    {
        Debug.Log($"<color=yellow>{scene.name} unloaded with data {SceneUtils.DictToString(SceneUtils.SceneData)}</color>");
    }

    public void LoadScene2()
    {
        SceneUtils.LoadScene("Scene2", LoadSceneMode.Additive, new Dictionary<string, string>()
        {
            {"field1", "value1"},
            {"field2", "value2"},
            {"field3", "value3"},
        });
    }
}
