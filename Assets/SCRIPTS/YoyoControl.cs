using UnityEngine;

public class YoyoControl : MonoBehaviour
{

    SpringJoint s;
    Rigidbody connectedYo;
    public float juggleForce;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        s = GetComponent<SpringJoint>();
        connectedYo = s.connectedBody;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            connectedYo.AddForce(transform.forward*juggleForce);
        }
    }

}
