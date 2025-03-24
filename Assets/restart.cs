using UnityEngine;

public class restart : MonoBehaviour
{
    public ball ball;
    public slider slider;
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
    }
}

