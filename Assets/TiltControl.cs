using UnityEngine;

public class TiltControl : MonoBehaviour
{
    [SerializeField] private GameObject floor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            floor.transform.Rotate(0, 0, 10f * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            floor.transform.Rotate(0, 0, -10f * Time.deltaTime);
        }
    }
}
