using UnityEngine;
using System.Collections;

public class PlayerCameraFollow : MonoBehaviour
{
    public float damping;
    public Transform target;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            Vector3 targetPos = target.position;
            targetPos.z = this.transform.position.z;
            this.transform.position = Vector3.Lerp(this.transform.position,targetPos, damping);

        }
    }
}
