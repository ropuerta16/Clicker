using UnityEngine;

public class Upgrade_AddScore : Upgrade
{
    
    public Upgrade_AddScore() 
    {

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
