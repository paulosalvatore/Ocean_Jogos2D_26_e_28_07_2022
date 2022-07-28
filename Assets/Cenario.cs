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

        // Caso a posição de X seja menor que -4
        // (está fora da câmera do lado esquerdo)
        // Somamos +8 na posição de X
        // (colocamos fora da câmera do lado direito)
        if (transform.position.x < -4) {
            transform.position = new Vector2(
                transform.position.x + 8,
                transform.position.y
            );
        }
    }
}
