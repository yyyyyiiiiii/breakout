using UnityEngine;

public class tile : MonoBehaviour
{
    public ball ball;
    public score score;
    public tiles tiles;

    void Start() {
        tiles.add(gameObject);
    }

    void OnCollisionExit2D(Collision2D collision) {
        var thing = collision.rigidbody;
        if (thing != ball.body) return;
        score.add(1);
        ball.accelerate(0.5f);
        gameObject.SetActive(false);
    }
}
