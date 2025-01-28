using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecondScript : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;
    }
}
