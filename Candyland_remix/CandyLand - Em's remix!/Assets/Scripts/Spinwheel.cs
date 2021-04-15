using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spinwheel : MonoBehaviour
{
    private Rigidbody2D rb2D;

    [SerializeField] private Slider forceSlider;
    [SerializeField] private Button spinButton;
    public void Spin()
    {
        spinButton.interactable = false; 
        rb2D.AddTorque(forceSlider.value, ForceMode2D.Impulse);
    }
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if (rb2D.angularVelocity > 0)
        {
            return;
        }

        spinButton.interactable = true;
    }
}
