using UnityEngine;
using UnityEngine.InputSystem;

public class slider : MonoBehaviour
{
    public InputAction move;
    public float speed = 15;
    public Rigidbody2D body;

    Vector3 initialPosition;

    void OnEnable() {
        move.Enable();
    }

    void OnDisable() {
        move.Disable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (body.bodyType != RigidbodyType2D.Dynamic)
            return;
        var value = move.ReadValue<Vector2>();
        body.linearVelocity = value * speed;
    }

    public void stop() {
        body.bodyType = RigidbodyType2D.Static;
    }

    public void reset() {
        body.bodyType = RigidbodyType2D.Dynamic;
        transform.position = initialPosition;
    }
}
