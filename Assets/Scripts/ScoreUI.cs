using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TextMeshProUGUI currentScoreTxt;//현재 점수
    [SerializeField] private TextMeshProUGUI HighScoreTxt; //최고 점수

    private float currentScore;
    private float highScore = 0f;

    private void Start()
    {
        highScore = PlayerPrefs.GetFloat("highScore", 0);

    }

    private void Update()
    {
        ScoreUp();
    }

    public void ScoreUp()
    {
        currentScore = Mathf.FloorToInt(transform.position.y * 100);

        if (highScore < currentScore)
        {
            highScore = currentScore;
            PlayerPrefs.SetFloat("highScore", currentScore);
            PlayerPrefs.Save();
        }

        currentScoreTxt.text = $"{currentScore} M";
        HighScoreTxt.text = $"{highScore} M";
    }
}


