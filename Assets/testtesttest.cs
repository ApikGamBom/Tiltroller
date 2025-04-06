using UnityEngine;
using UnityEngine.UI;

public class testtesttest : MonoBehaviour
{
    [SerializeField] private GameObject floor;
    [SerializeField] private Slider slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        floor.transform.rotation = Quaternion.Euler(0, 0, slider.value*-100);
    }
}
