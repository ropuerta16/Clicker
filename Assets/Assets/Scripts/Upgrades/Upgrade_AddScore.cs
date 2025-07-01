using TMPro;
using UnityEngine;

public class Upgrade_AddScore : Upgrade
{
    public TextMeshProUGUI UpNameTxt;
    public TextMeshProUGUI UpPrizeTxt;

    void Start()
    {
        UpNameTxt.text = name;
        UpPrizeTxt.text = "" + prize;
    }
    public override void AddUpgrades()
    {
        if (Score.Instance.score >= prize)
        {

            Score.Instance.score -= prize;
            AddScore.Instance.Clickvalue += 1;
            prize *= 2;
            UpPrizeTxt.text = "" + prize;
        }
    }
}
