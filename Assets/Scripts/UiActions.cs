using UnityEngine;
using UnityEngine.SceneManagement;

public class UiActions : MonoBehaviour
{
    public void AlterarCena(string cena) {
        SceneManager.LoadScene(cena);
    }
}
