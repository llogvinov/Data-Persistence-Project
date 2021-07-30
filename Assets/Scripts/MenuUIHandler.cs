using UnityEngine;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public Text BestScoreText;

    private void Start()
    {
        GameDataManager.Instance.LoadBestScore();
        UpdateBestScoreText(GameDataManager.Instance.BestScore);
    }

    private void UpdateBestScoreText(int score)
    {
        BestScoreText.text = "Best score: " + score;
    }

}
