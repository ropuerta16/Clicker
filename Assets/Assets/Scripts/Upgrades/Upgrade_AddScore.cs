using TMPro;
using UnityEngine;

public class Upgrade_AddScore : Upgrade
{
    public TextMeshProUGUI UpNameTxt;

    public void Start()
    {
        UpNameTxt.text = name;
    }
    public override void AddUpgrades()
    {
        if (Score.Instance.score >= prize)
        {

            Score.Instance.score -= prize;
            Score.Instance.score += 20;
        }
    }
}
