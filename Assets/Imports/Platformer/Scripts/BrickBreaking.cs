using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBreaking : MonoBehaviour
{
    public GameObject brick;
    void OnMouseDown()
    {
        Destroy(brick);
    }
}
