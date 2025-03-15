using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectible : MonoBehaviour
{

    public int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Coin":
                {
                    points++;
                    Debug.Log("points "+points);
                    Destroy(collision.gameObject);
                    break;
                }
           
        }
    }
}
