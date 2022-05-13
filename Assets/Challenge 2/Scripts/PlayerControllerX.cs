using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogTime;
    float m_dogTime;
    void Start()
    {
        m_dogTime = 0;
    }
    // Update is called once per frame
    void Update()
    {
        m_dogTime -= Time.deltaTime;
        if (m_dogTime <= 0)
        {
            SpawnDog();
        }

    }
    public void SpawnDog()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_dogTime = dogTime;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

        }
    }
}
  