using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score Instance { get; private set; }

    [SerializeField]
    public int score;
    public TextMeshProUGUI scoreTxt;
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        ActualizeScore();
    }
    public void ActualizeScore()
    {
        scoreTxt.text = "Score:" + score;
    }
}
