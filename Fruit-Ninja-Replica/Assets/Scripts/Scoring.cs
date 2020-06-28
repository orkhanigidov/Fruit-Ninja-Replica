using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public Text scoreText;
    public static int score;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        scoreText.text = score.ToString();
    }
}
