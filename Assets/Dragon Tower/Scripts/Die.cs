using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public GameObject Me;

        void OnTriggerStay2D(Collider2D col)
        {
            if (col.tag == "Sword")
            {
                Destroy(Me);
            }

        }
}
