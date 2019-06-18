using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    // Use this for initialization
    void Start()
    {

    }
    private Vector2 input = new Vector2();
    // Update is called once per frame
    void Update()
    {
        input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
    private void FixedUpdate()
    {
        Vector2 pos = this.transform.position;
        pos += (input.normalized * speed * Time.fixedDeltaTime);
        this.transform.position = pos;
    }
}
