using UnityEngine;
 
[ExecuteInEditMode]
public class ParalaxCamera : MonoBehaviour
{
    public delegate void ParallaxCameraDelegate(float deltaMovement);
    public ParallaxCameraDelegate onCameraTranslate;
 
    private float oldPos;
 
    void Start()
    {
        oldPos = transform.position.x;
    }
 
    void Update()
    {
        if (transform.position.x != oldPos)
        {
            if (onCameraTranslate != null)
            {
                float delta = oldPos - transform.position.x;
                onCameraTranslate(delta);
            }
 
            oldPos = transform.position.x;
        }
    }
}
