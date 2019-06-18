using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour
{
    public Vector2 Index;
    public void SetPosition(Vector2 index, float WidthOffset, float HeightOffset)
    {
        Index = index;
        this.transform.position = new Vector3(index.x*WidthOffset, index.y*HeightOffset, 0);
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
