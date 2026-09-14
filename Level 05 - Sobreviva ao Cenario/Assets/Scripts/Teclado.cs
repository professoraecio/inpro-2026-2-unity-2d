using UnityEngine;
using UnityEngine.InputSystem;
public class Teclado : MonoBehaviour
{
    public bool cima;
    public bool baixo;
    public bool esquerda;
    public bool direita;
    public bool z;
    public bool x;
    public bool espaco;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current == null) return;
        cima = Keyboard.current.upArrowKey.isPressed;
        baixo = Keyboard.current.downArrowKey.isPressed;
        esquerda = Keyboard.current.leftArrowKey.isPressed;
        direita = Keyboard.current.rightArrowKey.isPressed;
        z = Keyboard.current.zKey.isPressed;
        x = Keyboard.current.xKey.isPressed;
        espaco = Keyboard.current.spaceKey.isPressed;
    }
}
