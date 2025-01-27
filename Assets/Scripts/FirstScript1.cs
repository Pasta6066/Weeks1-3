using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript1 : MonoBehaviour
{
    public AnimationCurve curve;

    [Range(0, 1)]
    public float t;

    public Transform start;
    public Transform end;

    float speed = 0.01f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed;

        

        if(pos.x < -1.891 || pos.x > 1.888)
        {
            speed = speed * -1;      
        }
        transform.position = pos;

       // t += Time.deltaTime + speed;
       
      //  if (t > 1 || t < 0.1)
       // {
       //     print(t);
       //     speed *= -1;
       // }

      //  transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));

        
    }
}
