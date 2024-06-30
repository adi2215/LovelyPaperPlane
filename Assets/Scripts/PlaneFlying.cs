using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlaneFlying : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float steer = 20f;

    private Rigidbody2D rb;
    private float inputAxis;

    public Joystick joystick;

    public bool AbillityActivation = false;
    public bool AbillityActivationSmall = false;

    public Button AbillityButton;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (joystick.Vertical == 0)
        {
            inputAxis = Input.GetAxis("Vertical");
        }

        else
        {
            inputAxis = joystick.Vertical;
        }

        if (AbillityActivation == true)
        {
            AbillityActivation = false;
            speed *= 1.5f;
            AbillityButton.GetComponent<Button>().enabled = false;
            StartCoroutine(Abillity());
        }

        if (AbillityActivationSmall == true)
        {
            AbillityActivation = false;
            gameObject.transform.localScale = new Vector3(0.15f, 0.25f, 0.5f);
            AbillityButton.GetComponent<Button>().enabled = false;
            StartCoroutine(AbillitySmalll());
        }
    }

    private void FixedUpdate() 
    {
        rb.velocity = transform.right * speed * Time.fixedDeltaTime * 10f;
        rb.angularVelocity = inputAxis * steer * 10f;
    }

    public void AbillitySpeed() => AbillityActivation = true;
    public void AbillitySmall() => AbillityActivationSmall = true;
    
    IEnumerator AbillitySmalll()
    {
        yield return new WaitForSeconds(3f);
        gameObject.transform.localScale = new Vector3(0.25f, 0.35f, 0.5f);
        AbillityButton.GetComponent<Button>().enabled = true;
    }

    IEnumerator Abillity()
    {
        yield return new WaitForSeconds(3f);
        speed /= 1.5f;
        AbillityButton.GetComponent<Button>().enabled = true;
    }


    /*var keyboard = Keyboard.current;

        inputAxis = 0;
        if (keyboard.downArrowKey.isPressed || keyboard.sKey.isPressed)
            inputAxis = -1.0f;
        else if (keyboard.upArrowKey.isPressed || keyboard.wKey.isPressed)
            inputAxis = 1.0f;*/
}
