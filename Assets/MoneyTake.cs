using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyTake : MonoBehaviour
{
    public MainData data;
    public Text text;
    public GameObject effect;

    private void OnTriggerEnter2D(Collider2D col)
    {
        PlaneFlying target = col.GetComponent<PlaneFlying>();
        if (target != null)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            data.countMoney++;
            text.text = data.countMoney.ToString();
            Destroy(gameObject);
        }
    }
}
