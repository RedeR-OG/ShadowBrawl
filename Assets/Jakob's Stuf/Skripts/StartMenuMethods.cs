using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void StartButton(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitButton()
    {
        Debug.Log("Go Away!!!");
        Application.Quit();
    }
}
