using UnityEngine;

public class AutoClickerParameters : MonoBehaviour
{
    private float CoolDown = 1f;

    void Update()
    {
        CoolDown -= Time.time;
        if (CoolDown < 0 )
        {
            Score.Instance.score += AddScore.Instance.Clickvalue;
            CoolDown = 1f;
        }
    }
}
