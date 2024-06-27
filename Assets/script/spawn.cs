using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[ ]  prefab;
    public Transform[ ] pos;

    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {   //반복해서 불러
       InvokeRepeating("CreateFruit", 2, 2);
        audio = GetComponent<AudioSource>();
    }

    void CreateFruit()
    {
        for(int i = 0; i < 2; i++)
        {
            int iFruit = Random.Range(0, prefab.Length);
            int iPos = Random.Range(0, pos.Length);
            GameObject o = Instantiate(prefab[iFruit], pos[iPos].position, Quaternion.identity);

            Destroy(o, 5f);

            Rigidbody rb = o.GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * Random.Range(10f, 15f), ForceMode.VelocityChange);
        }

        audio.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
