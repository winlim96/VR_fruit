using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
    public GameObject effect;

    AudioSource audio;

    static int score;
    public Text textScore;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
                                                                                                        //out 은 hit 의 결과값이 돌아온다 // 5미터까지 /생략하면 무한댇
        if(Physics.Raycast(transform.position, transform.forward, out hit, 5))
        {
            Destroy(hit.transform.gameObject);

            Instantiate(effect, hit.point, Quaternion.LookRotation(hit.normal));
            audio.Play();

            score += 10;
            textScore.text = "Score : " + score;
        }
    }
}
