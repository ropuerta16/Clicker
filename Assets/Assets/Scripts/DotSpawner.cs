using System.Collections.Generic;
using UnityEngine;

public class DotSpawner : MonoBehaviour
{
    public GameObject Dot;

    public DotSpawner()
    {
        Vector3 position = new Vector3(Random.Range(0,0), Random.Range(0, 0), 0);
        GameObject d = Instantiate(Dot,position,Quaternion.identity);
        //dots.Add(d);
    }
}
