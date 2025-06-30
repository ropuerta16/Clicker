using System.Drawing;
using System.Xml.Linq;
using UnityEngine;

public class Upgrade_Autoclicker : Upgrade
{
    public GameObject Autoclicker;
    public Upgrade_Autoclicker()
    {

    }

    public override void AddUpgrades()
    {
        if (Score.Instance.score >= prize)
        {
            Score.Instance.score -= prize;
            Instantiate(Autoclicker, Vector3.zero, Quaternion.identity);
        }
    }
}
