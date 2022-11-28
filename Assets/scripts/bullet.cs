using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("destroy_bullet", 0.2f);
    }

    void destroy_bullet()
    {
        Destroy(gameObject);
    }
}
