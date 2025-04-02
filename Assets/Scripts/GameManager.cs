using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if (instance)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }
    public static void LoadScene(string newSceneName)
    {
        SceneManager.LoadScene(newSceneName);
    }
    public static void Quit()
    {
        Application.Quit();
    }
}
