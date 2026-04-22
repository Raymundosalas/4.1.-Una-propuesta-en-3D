using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    public Text scoreText;

    void Update()
    {
        scoreText.text = "Puntos: " + score;
    }
}
