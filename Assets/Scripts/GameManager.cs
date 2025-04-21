using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public SceneStack sceneStack { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            sceneStack = new SceneStack(SceneManager.GetActiveScene().name);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
