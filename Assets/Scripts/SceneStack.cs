using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStack : MonoBehaviour
{
    private Stack<String> sceneStack = new Stack<String>();

    public void PushScene(string sceneName)
    {
        sceneStack.Push(sceneName);
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void PopScene()
    {
        sceneStack.Pop();
        if (sceneStack.Count > 0)
        {
            string sceneName = sceneStack.Peek();
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
        else
        {
            Debug.LogWarning("No more scenes in the stack to pop.");
        }
    }
}
