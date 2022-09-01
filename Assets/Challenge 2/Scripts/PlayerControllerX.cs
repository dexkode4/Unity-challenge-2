using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private bool CanCatch = false;
    private float spawnDogInterval = 2;

      void Start()
    {
        InvokeRepeating("SetCatch", 0, spawnDogInterval);
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && CanCatch)
        {
            CatchBall();
            CanCatch = false;
        }
    }

    void CatchBall()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }

    void SetCatch(){
        CanCatch = true;
    }
}
