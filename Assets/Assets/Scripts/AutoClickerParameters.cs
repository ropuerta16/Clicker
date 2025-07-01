using UnityEngine;

public class AutoClickerParameters : MonoBehaviour
{
    private void Start()
    {
        InvokeRepeating("RepeatScore", 0f,1f);
    }

    private void RepeatScore()
    {
        Score.Instance.score += AddScore.Instance.Clickvalue;

    }
}
