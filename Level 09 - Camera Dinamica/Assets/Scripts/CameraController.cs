using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    [SerializeField] bool cameraLivre = false;
    public float minX = 0f;
    public float minY = 0f;
    [SerializeField] float toleranciaY = 2f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if(cameraLivre == false)
        {
            // Coordenada X do player ou Xmin caso ultrapasse
            float alvoX = Mathf.Max(player.position.x,minX);
        }
        else
        {
            transform.position =
                Vector2.Lerp(transform.position, player.position,0.1f);
        }
    }
}
