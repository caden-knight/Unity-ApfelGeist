using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float verticalInput;
    private float horizontalInput;

    [SerializeField]
    private float speed = 10f;

    [SerializeField]
    private float rotationSpeed = 90f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal") * speed;
        verticalInput = Input.GetAxis("Vertical") * rotationSpeed;

        transform.Translate(Vector2.right * Time.deltaTime * horizontalInput);
        transform.Rotate(Vector3.forward, Time.deltaTime * verticalInput);

    }
}
