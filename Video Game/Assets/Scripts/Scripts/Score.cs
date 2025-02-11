using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    public static string levelScore;

    void Update()
    {
        scoreText.text = player.position.z.ToString("0"); //save position (float) as score text (string)
                                                          //"0" to format as an int instead of float
    }

    private void OnDestroy()
    {
        levelScore = scoreText.text;
    }
}
