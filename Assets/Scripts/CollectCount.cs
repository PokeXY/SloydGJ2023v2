using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCount : MonoBehaviour
{
    TMPro.TMP_Text text;
    int count;

    void Start() => UpdateCount();
    
    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }

    void OnEnable() => Collect.OnCollected += OnCollectCollected;
    void OnDisable() => Collect.OnCollected -= OnCollectCollected;

    void UpdateCount()
    {
        text.text = $"{count} / {Collect.total}";
    }


    void OnCollectCollected()
    {
        count++;
        UpdateCount();
    }

}
