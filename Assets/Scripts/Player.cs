using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody playerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        // 퍼블릭인 경우 드레그앤드롭으로 해당 객체의 RigidBody 컴포넌트를 가져오는 것과 같다.
        playerRigidbody = GetComponent<Rigidbody>(); // Generic

    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Hello Unity");

        // User Input
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
        float fallSpeed = playerRigidbody.velocity.y;

        Vector3 velocity = new Vector3(inputX, 0, inputZ);
        velocity = velocity * speed;
        velocity.y = fallSpeed;
        playerRigidbody.velocity = velocity;

    }
}
