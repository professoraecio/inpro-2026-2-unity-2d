using UnityEngine;

public class StarBall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if(collision2D.gameObject.CompareTag("Player"))
        {            
            Rigidbody2D rb = collision2D.gameObject.GetComponent<Rigidbody2D>();
            if(rb != null)
            {
                if(collision2D.contacts[0].normal.y < 0.5f)
                {
                    Destroy(collision2D.gameObject);
                }
            }
        }
    }
}
