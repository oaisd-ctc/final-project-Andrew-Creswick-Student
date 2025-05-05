using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int goldAmount = 0;
    public Text goldAmountText;
    private void Awake()
    {
        if (instance)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            //DontDestroyOnLoad(this);
        }
        goldAmountText = GameObject.Find("GoldAmount").GetComponent<Text>();
    }
    public void LoadScene(string newSceneName)
    {
        SceneManager.LoadScene(newSceneName);
    }
    public void GrabMouse(bool grabMouse)
    {
        if (grabMouse)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else if (grabMouse == false)
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public static void Quit()
    {
        Application.Quit();
    }
    public void ChangeGoldAmount(int amount)
    {
        goldAmount += amount;
    }
    private void Update()
    {
        goldAmountText.text = goldAmount.ToString();
    }
}
