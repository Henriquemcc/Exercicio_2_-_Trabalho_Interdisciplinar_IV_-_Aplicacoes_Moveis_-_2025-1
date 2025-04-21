using UnityEngine;
using UnityEngine.SceneManagement;

public class UIActions : MonoBehaviour
{
    private SceneStack sceneStack;

    void Awake()
    {
        sceneStack = GameManager.Instance.sceneStack;
    }

    public void LoadSceneStack(string sceneName) {
        sceneStack.PushScene(sceneName);
    }

    public void PopSceneStack() {
        sceneStack.PopScene();
    }
}
