using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpScript : MonoBehaviour
{
    public AnimationCurve curve;

    [Range(0, 1)]
    public float t;

    public Transform start;
    public Transform end;

    float speed = 0.0001f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.localPosition;
        pos.x += speed;

        t += Time.deltaTime + speed;

          if (t > 1)
         {
            t = 0;
         }

         transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
}
