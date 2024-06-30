using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCoin : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 0.9f;
    }

    public void Again()
    {
        Time.timeScale = 1f;
    }
}
