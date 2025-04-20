using UnityEngine;
using UnityEngine.SceneManagement;

public class UIActions : MonoBehaviour
{
    public void AlterarCena(string cena) {
        SceneManager.LoadScene(cena);
    }
}
