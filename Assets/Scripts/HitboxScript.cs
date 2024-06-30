using UnityEngine;

public class HitboxScript : MonoBehaviour
{
    public int health = 7;
    public float timer = 0;
    public HealthBar healthBar;
    public GameObject win;
    public GameObject lose;
    public GameObject zone;

    public ManagerScene NewScene;

    private void Start()
    {
        healthBar.SetMaxHealth(health);
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("enemy") && timer <= 0)
        {
            health -= 1;
            healthBar.SetHealth(health);
            timer = 1;
        }

        if (col.gameObject.CompareTag("trigger"))
        {
            zone.SetActive(true);
            win.GetComponent<CommandBox>().OpenBox();
        }

        if (col.gameObject.CompareTag("Ending"))
        {
            NewScene.LoadNextLevel(1);
        }
    }

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            Debug.Log(timer);
        }

        if (health <= 0)
        {
            Time.timeScale = 0.1f;
            zone.SetActive(true);
            lose.GetComponent<CommandBox>().OpenBox();
        }
    }
}
