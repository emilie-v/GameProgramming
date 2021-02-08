using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Nametag : MonoBehaviour
{
    [SerializeField] Transform car;
    [SerializeField] TextMeshProUGUI nametag;
    [SerializeField] Vector3 offset = new Vector3(0, 0, 0);

    private void Start()
    {
        nametag = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        {
            transform.position = car.position + offset;
            nametag.text = car.name;
        }
    }
}
