using System.Drawing;
using System.Xml.Linq;
using TMPro;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Upgrade_Autoclicker : Upgrade
{
    public GameObject Autoclicker;
    public TextMeshProUGUI UpNameTxt;
    public TextMeshProUGUI UpPrizeTxt;

    public GameObject AutoclickerParent;

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

            GameObject a = Instantiate(Autoclicker, AutoclickerParent.transform);

            a.transform.position = new Vector3(2 * (AutoclickerParent.transform.childCount - 1), 0, 0);

            prize *= 2;
            UpPrizeTxt.text = "" + prize;
        }
    }
}
