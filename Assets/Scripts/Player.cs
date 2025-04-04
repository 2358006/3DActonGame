using UnityEngine;
public class Player : MonoBehaviour
{
    public float speed = 0f;
    float hAxis = 0f;
    float vAxis = 0f;

    Vector3 moveVec = Vector3.zero;

    void Start()
    {

    }
    void Update()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");

        moveVec = new Vector3(hAxis, 0f, vAxis).normalized;

        transform.position += moveVec * speed * Time.deltaTime;
    }
}
