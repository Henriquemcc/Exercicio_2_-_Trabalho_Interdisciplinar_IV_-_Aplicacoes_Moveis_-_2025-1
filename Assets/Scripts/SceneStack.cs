using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStack
{
    private Stack<String> sceneStack;

    public SceneStack(string sceneName)
    {
        sceneStack = new Stack<String>();
        sceneStack.Push(sceneName);
        Debug.Log("SceneStack initialized with scene: " + sceneName);
    }

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
