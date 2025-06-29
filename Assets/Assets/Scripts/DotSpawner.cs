using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DotSpawner : MonoBehaviour
{
    public GameObject Dot;

    private float CountDownSpawner;
    public float MaxCountDownSpawner;

    private void Update()
    {
        CountDownSpawner -= Time.deltaTime;

        if (CountDownSpawner <= 0 )
            SpawnDot();

    }


    public void SpawnDot()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-8.0f, 3.0f), Random.Range(-4.0f, 2.0f), 0);
        Instantiate(Dot, randomPosition, Quaternion.identity);
        CountDownSpawner = MaxCountDownSpawner;
    }
}
