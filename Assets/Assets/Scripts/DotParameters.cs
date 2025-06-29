using TreeEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class DotParameters : MonoBehaviour
{

    void Awake()
    {
        float scale = Random.Range(0, 5);
        Color color = new Color(Random.Range(0,255), Random.Range(0, 255), Random.Range(0, 255));

        transform.localScale = new Vector3(scale,scale,1); 

        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        spriteRenderer.color = color;
    }
}
