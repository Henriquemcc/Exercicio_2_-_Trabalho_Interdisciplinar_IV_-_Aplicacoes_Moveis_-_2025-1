using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public SceneStack sceneStack { get; private set; }

    private void Awake()
    {
        if (Instance != null) Destroy(this.gameObject);
        Instance = this;
        sceneStack = new SceneStack();
    }
}
