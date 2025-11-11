using UnityEngine;

public class WASD_movement_script : MonoBehaviour
{
    public float baseSpeed;
    float moveSpeed;

    void Start()
    {
        moveSpeed = baseSpeed;
    }
    void FixedUpdate()
    {
        WASD_movement();
    }

    void WASD_movement() {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(horizontal * baseSpeed, vertical * baseSpeed));

        if (horizontal != 0 && vertical != 0)
        {
            moveSpeed = baseSpeed * 0.66f;
        }

        else
        {
            moveSpeed = baseSpeed;
        }
    }

}
