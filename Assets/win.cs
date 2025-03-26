using UnityEngine;

public class win : MonoBehaviour
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
        score.gameObject.SetActive(false);
        lives.gameObject.SetActive(false);
    }

    public void onClick() {
        gameObject.SetActive(false);
        ball.reset();
        slider.reset();
        score.reset();
        lives.reset();
        tiles.reset();
        score.gameObject.SetActive(true);
        lives.gameObject.SetActive(true);
    }
}
