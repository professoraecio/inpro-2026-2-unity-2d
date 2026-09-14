using UnityEngine;

public class PlataformaQueSome : MonoBehaviour
{
    public float tempoParaSumir = 1f;
    private bool jogadorSaiu = false;
    private bool entrouPorCima = false;

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if(collision2D.gameObject.CompareTag("Player"))
        {
                if(collision2D.contacts[0].normal.y < -0.5f)
                {
                    entrouPorCima = true;
                }
           
        }
    }

    private void OnCollisionExit2D(Collision2D collision2D)
    {
        if(collision2D.gameObject.CompareTag("Player") && !jogadorSaiu && entrouPorCima)
        {
            jogadorSaiu = true;
            Invoke(nameof(Sumir),tempoParaSumir);
        }
    }

    private void Sumir()
    {
        gameObject.SetActive(false);
    }


}
