using UnityEngine;
using UnityEngine.SceneManagement;

public class UIActions : MonoBehaviour
{
    public void AlterarCena(string cena) {
        SceneManager.LoadScene(cena);
    }

    public void AlterarCenaAditivo(string cena) {
        SceneManager.LoadScene(cena, LoadSceneMode.Additive);
    }

    public void RetirarCenaAditivo(string cena) {
        SceneManager.UnloadSceneAsync(cena);
    }
}
