using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class Score : MonoBehaviour
{
    public Text scoreDisplay;
    public Animator scoreAnimator;
    public int nextLevel = 0;
    public int threeStars = 3;
    public int twoStars = 6;
    public void EndLevel()
    {
        Cannon cannon = FindAnyObjectByType<Cannon>();
        if (cannon)
        {
            int numProjectiles = cannon.numProjectiles;
            if (numProjectiles <= threeStars)
            {
                scoreDisplay.text = "Three Stars!";
                scoreAnimator.SetInteger("Stars", 3);
            }
            else if (numProjectiles <= twoStars)
            {
                scoreDisplay.text = "Two Stars!";
                scoreAnimator.SetInteger("Stars", 2);
            }
            else
            {
                scoreDisplay.text = "One Star!";
                scoreAnimator.SetInteger("Stars", 1);
            }
            Invoke("NextLevel", 2);
        }
    }
    void NextLevel()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
