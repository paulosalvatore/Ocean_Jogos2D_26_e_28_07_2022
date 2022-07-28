using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cenario : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime -> Recebe o tempo exato entre um
        // frame e outro
        // Vector2.left -> x: -1 y: 0
        transform.Translate(Vector2.left * Time.deltaTime);
    }
}
