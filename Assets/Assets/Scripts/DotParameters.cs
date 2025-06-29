using TreeEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class DotParameters : MonoBehaviour
{
    void Awake()
    {
        int r = Random.Range(0, 2);
        int g = Random.Range(0, 2);
        int b = Random.Range(0, 2);

        float scale = Random.Range(1.0f, 2.0f);

        transform.localScale = new Vector3(scale,scale,1);

        Color color = new Color(r, g, b);

        gameObject.GetComponent<SpriteRenderer>().color = color;
    }
}
