using TMPro;
using UnityEngine;

public class AddScore : MonoBehaviour
{

    public static AddScore Instance { get; private set; }

    [SerializeField]
    public int Clickvalue;

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
        Clickvalue = 1;
    }

    public void Add()
    {
        Score.Instance.score += Clickvalue;
        Score.Instance.ActualizeScore();
    }
}
