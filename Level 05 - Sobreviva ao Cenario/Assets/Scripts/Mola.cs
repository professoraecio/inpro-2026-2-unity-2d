using UnityEngine;

public class Mola : MonoBehaviour
{
    [SerializeField] private float forcaPulo = 15f;
    
    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if(collision2D.gameObject.CompareTag("Player"))
        {
            Rigidbody2D rb = collision2D.gameObject.GetComponent<Rigidbody2D>();
            if(rb != null)
            {
                if(collision2D.contacts[0].normal.y < 0.5f)
                {
                    rb.linearVelocity = Vector2.zero;
                    rb.AddForce(Vector2.up * forcaPulo, ForceMode2D.Impulse);
                }
            }
        }
    }
}
