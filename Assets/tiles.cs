using UnityEngine;
using System.Collections.Generic;

public class tiles : MonoBehaviour
{
    public List<GameObject> elements;
 
    public void add(GameObject tile) {
        elements.Add(tile);
    }

    public void reset() {
        foreach (GameObject element in elements) {
            element.SetActive(true);
        }
    }
}
