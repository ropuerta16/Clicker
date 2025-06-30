using System.Drawing;
using System.Xml.Linq;
using TMPro;
using UnityEngine;

public class Upgrade_Autoclicker : Upgrade
{
    public GameObject Autoclicker;
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
            Instantiate(Autoclicker, Vector3.zero, Quaternion.identity);
        }
    }
}
