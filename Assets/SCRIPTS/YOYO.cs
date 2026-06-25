using UnityEngine;

public class YOYO : MonoBehaviour
{
    public Transform yoyoTransform;
    public Rigidbody rB;

    //wave variables
    private int amplitude = 1;
    private int frequency = 1;

    public GameObject yoyo;

    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        yoyoTransform = GetComponent<Transform>();yoyoTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Move();
        }
    }

    public void Move()
    {
        float x = Mathf.Sin(Time.time * frequency) * amplitude;
        float y = this.transform.position.y;
        float z = this.transform.position.z;

        this.yoyoTransform.position = new Vector3(x, y, z);
    }


}
