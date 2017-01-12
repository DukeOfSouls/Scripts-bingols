using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour
{
    public ShootScript shootscript;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "target")
        {
            shootscript.count++;
            Debug.Log(shootscript.count);
        }
    }
}
