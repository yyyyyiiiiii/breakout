using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody2D body;
    public Rigidbody2D slider;
    public Rigidbody2D deadzone;
    public GameObject restart;
    public GameObject gameover;
    public lives lives;
    public float speed = 7;

    public Vector2 initialMoveDirection = new Vector2(1, -1);
    float initialSpeed;
    Vector3 initialPosition;

    void velocitialize(Vector2 velocity) {
        body.linearVelocity = velocity.normalized * speed;
    }

    public void accelerate(float value) {
        speed += value;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initialSpeed = speed;
        initialPosition = transform.position;
        velocitialize(initialMoveDirection);
    }

    void OnCollisionExit2D(Collision2D collision) {
        var thing = collision.rigidbody;
        if (thing != slider) return;
        var value = 2 * body.linearVelocity + slider.linearVelocity;
        if (Mathf.Abs(value.x) > Mathf.Abs(value.y)) {
            var y = Mathf.Abs(value.x);
            var x = Mathf.Abs(value.y);
            if (value.x < 0)
                x *= -1;
            value = new Vector2(x, y);
        } 
        velocitialize(value);
    }

    void OnCollisionEnter2D(Collision2D collision) {
        var thing = collision.rigidbody;
        if (thing != deadzone) return;
        lives.decrease(1);
        if (lives.total > 0) {
            restart.SetActive(true);
        } else {
            gameover.SetActive(true);
        }
    }

    public void stop() {
        body.bodyType = RigidbodyType2D.Static;
    }

    public void reset() {
        body.bodyType = RigidbodyType2D.Dynamic;
        transform.position = initialPosition;
        speed = initialSpeed;
        velocitialize(initialMoveDirection);
    }
}
