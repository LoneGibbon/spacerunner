using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "Side")
        {
            Destroy(this.gameObject);
        }
        if (coll.gameObject.tag == "Player")
        {
            //Game Over condition..
            Destroy(this.gameObject);
            Destroy(coll.gameObject);
        }
    }
}
