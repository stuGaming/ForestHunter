using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MapTiler : MonoBehaviour
{
    public Tile tilePrefab;
    public List<Tile> grassTiles = new List<Tile>();
    public int width;
    public int height;
    public float widthGap;
    public float heightGap;
    public Transform target;
    private Vector3 offset;
    public Vector2 currentPosition;

    // Use this for initialization
    void Start()
    {
        offset = Vector3.zero - (new Vector3((width / 2) * widthGap, (height / 2) * heightGap, 0));
        for(int i = 0; i < width; i++)
        {
            
            for(int h = 0; h < height; h++)
            {
                Tile tile = Instantiate(tilePrefab, this.transform);
                grassTiles.Add(tile);
                tile.SetPosition(new Vector2(i- (width / 2), h - (height/ 2)), widthGap, heightGap);

            }
        }
        currentPosition = new Vector2(0, 0);
         
    }
    private void UpdatePositions(Vector2 pos)
    {
        for(int i = 0; i < grassTiles.Count; i++)
        {
            if(Mathf.Abs(grassTiles[i].Index.x - pos.x)>Mathf.FloorToInt((float)width/2f))
            {
                if (grassTiles[i].Index.x > pos.x)
                {
                    grassTiles[i].SetPosition(new Vector2(grassTiles[i].Index.x - width, grassTiles[i].Index.y),widthGap,heightGap);
                }
                else
                {
                    grassTiles[i].SetPosition(new Vector2(grassTiles[i].Index.x + width, grassTiles[i].Index.y), widthGap, heightGap);
                }
            }
            if (Mathf.Abs(grassTiles[i].Index.y - pos.y) > Mathf.FloorToInt((float)height / 2f))
            {
                if (grassTiles[i].Index.y> pos.y)
                {
                    grassTiles[i].SetPosition(new Vector2(grassTiles[i].Index.x , grassTiles[i].Index.y-height), widthGap, heightGap);
                }
                else
                {
                    grassTiles[i].SetPosition(new Vector2(grassTiles[i].Index.x, grassTiles[i].Index.y+ height), widthGap, heightGap);
                }
            }
        }
        currentPosition = pos;
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 newIndexes = new Vector2(Mathf.FloorToInt(target.position.x / widthGap), Mathf.FloorToInt(target.position.y / heightGap));
        if (newIndexes != currentPosition)
        {
            UpdatePositions(newIndexes);
        }
    }
}
