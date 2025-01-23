using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public AnimationCurve curve;
    [Range(0, 1)]
    public float t;
    public AnimationCurve curve2;
    [Range(0, 1)]
    public float t2;

    float speed = -1;
    bool isJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.y = curve.Evaluate(t);

        Vector3 kickFlip = transform.eulerAngles;
        kickFlip.z = curve2.Evaluate(t2) * speed;


        Vector2 squareInScreenSpace = Camera.main.WorldToScreenPoint(pos);
        if (squareInScreenSpace.x < -10 || squareInScreenSpace.x > Screen.width)
        {
            speed = speed * -1;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            isJumping = true;
        }
        if (isJumping == true)
        {
            t += Time.deltaTime;

            t2 += Time.deltaTime;



            transform.position = pos;
            transform.eulerAngles = kickFlip;



                if (t > 1)
                {
                    t = 0;
                    t2 = 0;
                    kickFlip.z = 0;
                    transform.eulerAngles = kickFlip;
                    isJumping = false;
                }


            }

        }
    
}
