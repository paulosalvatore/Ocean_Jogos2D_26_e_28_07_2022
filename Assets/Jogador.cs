using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    // Acessar o Rigidbody na Unity
    public Rigidbody2D rb;

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
        // print("Pular!");

        // Adicionamos uma Força ao Rigidbody
        rb.AddForce(180f * Vector2.up);
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Inimigo")) {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
}
