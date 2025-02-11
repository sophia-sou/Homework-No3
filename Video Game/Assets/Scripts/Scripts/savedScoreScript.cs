using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private string scoreString;

    void Start()
    {
        scoreString = Score.levelScore;

        scoreText.text = "Score is equal to: " + scoreString; 
    }
}
