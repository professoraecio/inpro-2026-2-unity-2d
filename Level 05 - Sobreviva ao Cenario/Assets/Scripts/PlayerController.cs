using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidade = 5f;
    public float forcaPulo = 9f;

    private Rigidbody2D rb;
    public bool noChao = false;

    Teclado teclado;

    private float horizontal;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        teclado = GetComponent<Teclado>();
    }

    
    void Update()
    {
        if(teclado.esquerda)
            horizontal = -1f;
        else if (teclado.direita)
            horizontal = 1f;
        else
            horizontal = 0f;
        
        if(teclado.espaco && noChao)
        {
            rb.AddForce(Vector2.up * forcaPulo, ForceMode2D.Impulse);
            noChao = false;
        }
    }

    void FixedUpdate()
    {
        Vector2 vel = rb.linearVelocity;
        vel.x = horizontal * velocidade;
        rb.linearVelocity = vel;
    }

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if(collision2D.gameObject.CompareTag("Chao"))
        {
            noChao = true;
        }
    }
}
