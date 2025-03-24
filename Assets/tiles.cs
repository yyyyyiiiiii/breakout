using UnityEngine;
using System.Collections.Generic;

public class tiles : MonoBehaviour
{
    public List<GameObject> elements;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void add(GameObject tile) {
        elements.Add(tile);
    }

    public void reset() {
        foreach (GameObject element in elements) {
            element.SetActive(true);
        }
    }
}
