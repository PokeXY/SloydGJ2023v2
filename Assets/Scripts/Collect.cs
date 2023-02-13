using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Collect : MonoBehaviour
{
    public static event Action OnCollected;
    public static int total;

    void Awake() => total++;
 

    void Update()
    {
        transform.localRotation = Quaternion.Euler(0, Time.time * 100f, 90f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnCollected?.Invoke();
            Destroy(gameObject);
        }
    }

}
