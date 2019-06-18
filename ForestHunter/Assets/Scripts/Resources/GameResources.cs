using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameResources : MonoBehaviour
{
    public static GameResources Instance;

    // Start is called before the first frame update
    void Awake()
    {
        if (GameResources.Instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            GameResources.Instance = this;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
