using UnityEngine;
using UnityEditor ;
public class Move : MonoBehaviour
{
    private Rigidbody rb ;
    public float speed = 10f ;
    private Vector3 upDown = Vector3.forward ;
    private Vector3 rightLeft = Vector3.right;

    private int dirUp = 0 ;
    private int dirRight = 0 ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>() ;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)) dirRight = 1 ;
        else if(Input.GetKey(KeyCode.A)) dirRight = -1 ;
        else dirRight = 0 ;

        if(Input.GetKey(KeyCode.W)) dirUp = 1 ;
        else if(Input.GetKey(KeyCode.S)) dirUp = -1 ;
        else dirUp = 0 ;

        rb.linearVelocity = (dirUp * upDown + dirRight * rightLeft) * speed ;
    }
}
