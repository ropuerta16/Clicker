using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DotSpawner : MonoBehaviour
{
    public GameObject Dot;

    //List<GameObject> dots;

    private float CountDownSpawner;
    public float MaxCountDownSpawner;

    public DotSpawner()
    {
    }

    private void Update()
    {
        CountDownSpawner -= Time.deltaTime;

        if (CountDownSpawner <= 0 )
            SpawnDot();

    }


    public void SpawnDot()
    {
        Vector3 position = new Vector3(Random.Range(0, 10), Random.Range(0, 10), 0);
        GameObject d = Instantiate(Dot, position, Quaternion.identity);
        //dots.Add(d);
        CountDownSpawner = MaxCountDownSpawner;
    }
}
