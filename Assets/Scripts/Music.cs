using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {

    public AudioClip clip1, clip2, clip;
    public AudioSource audio;
    public static bool check = true;

	void Start () {
        if (check)
        {
            audio = GetComponent<AudioSource>();

            DontDestroyOnLoad(gameObject);

            int a = Random.Range(0, 2);
            Debug.Log(a);
            if (a == 0)
            {
                clip = clip1;
            }
            else
            {
                clip = clip2;
            }

            audio.clip = clip;
            audio.Play();
            audio.loop = true;
            check = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
