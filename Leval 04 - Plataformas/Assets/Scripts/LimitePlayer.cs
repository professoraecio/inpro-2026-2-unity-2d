using UnityEngine;

public class LimitePlayer : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 pos = rb.position;

        pos.x = pos.x <= -8 ? -8 : pos.x;
        pos.x = pos.x >= 8 ? 8 : pos.x;
        pos.y = pos.y <= -4 ? -4 : pos.y;
        pos.y = pos.y >= 4 ? 4 : pos.y;

        rb.position = pos;
    }

    void Update()
    {
        
    }
}
