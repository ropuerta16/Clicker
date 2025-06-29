using UnityEngine;

public abstract class Upgrade : MonoBehaviour
{
    public string Name;
    public int prize;

    public abstract void AddUpgrades();
}
