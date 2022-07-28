using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Detectar a ação do jogador
        if (Input.GetButtonDown("Jump")) {
            Pular();
        }
    }

    void Pular()
    {
        print("Pular!");
    }
}
