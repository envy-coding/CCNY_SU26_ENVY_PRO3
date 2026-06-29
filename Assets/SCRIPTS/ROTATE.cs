using UnityEngine;

public class ROTATE : MonoBehaviour
{
    public int speed = 50;
    public float position;

    void Start()
    {
        transform.position = Vector3.zero;
    }
    void Update()
    {
        transform.Rotate(Vector3.right * 10 * speed * Time.deltaTime);
    }
}
