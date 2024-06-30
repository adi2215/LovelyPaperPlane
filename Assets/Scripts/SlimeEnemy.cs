using UnityEngine;

public class SlimeEnemy : MonoBehaviour
{
    private void Start()
    {
        Destroy(gameObject, 3f);
    }
}
