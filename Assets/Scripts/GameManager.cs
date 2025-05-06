using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.ProBuilder.MeshOperations;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int goldAmount = 0;
    public int highScore = 0;
    public Text goldAmountText;
    public Text highScoreRecord;
    [SerializeField] string sceneName = "";
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
        highScoreRecord = GameObject.Find("HighScoreRecord").GetComponent<Text>();
        
        sceneName = SceneManager.GetActiveScene().name;
    }
    private void Start()
    {
        if (sceneName=="Level1")
        {
            highScore = PlayerPrefs.GetInt("HighScore1", 0);
        } else
        {
            highScore = PlayerPrefs.GetInt("HighScore2", 0);
        }
        highScoreRecord.text = highScore.ToString();
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
        if (highScoreRecord)
        {
            if(highScore < goldAmount)
            {
                highScore = goldAmount;
                highScoreRecord.text = highScore.ToString();
            }
        }
    }
    private void OnDestroy()
    {
        if (sceneName == "Level1")
        {
            PlayerPrefs.SetInt("HighScore1", highScore);
        }
        else 
        {
            PlayerPrefs.SetInt("HighScore2", highScore);
        }
        PlayerPrefs.Save();
    }
}
