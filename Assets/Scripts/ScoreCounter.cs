using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    static ScoreCounter instansce;

    int score;
    [SerializeField]
    TextMeshProUGUI scoretext;

    private void Start()
    {
        instansce = this;
    }

    static public void AddPoint(int point)
    {
        instansce.score += point;
        instansce.scoretext.text = "Score: " + instansce.score.ToString();
    }

}
