using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public GameObject Player;

    public float offsetX;
    public float offsetY;
    public float offsetZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 FixedPos = new Vector3(Player.transform.position.x + offsetX, Player.transform.position.y + offsetY, Player.transform.position.z + offsetZ);
        
        transform.position = FixedPos;

    }
}
