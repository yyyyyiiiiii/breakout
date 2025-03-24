using UnityEngine;

public class gameover : MonoBehaviour
{
    public ball ball;
    public slider slider;
    public score score;
    public lives lives;
    public tiles tiles;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable() {
        ball.stop();
        slider.stop();
    }

    public void onClick() {
        gameObject.SetActive(false);
        ball.reset();
        slider.reset();
        score.reset();
        lives.reset();
        tiles.reset();
    }
}
