using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpScript : MonoBehaviour
{
    public AnimationCurve curve;

    [Range(0, 1)]
    public float t;

    public AnimationCurve curve2;

    [Range(0, 1)]
    public float t2;

    public Transform start;
    public Transform end;

    public Transform start2;
    public Transform end2;

    float speed = 0.0001f;

    bool up = true;
    bool down = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(t2 > 1)
        {
            t2 = 0;
            down = false;
            up = true;
            t = 0;
        }
        if(up == true)
        {
            t += Time.deltaTime + speed;
            transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
        }
        if (t > 1)
        {   
            t = 0;
            up = false;
            down = true;
            t2 = 0;
        }
        if (down == true)
        {
            t2 += Time.deltaTime + speed;
            transform.position = Vector2.Lerp(start2.position, end2.position, curve.Evaluate(t2));
        }


    }
}
