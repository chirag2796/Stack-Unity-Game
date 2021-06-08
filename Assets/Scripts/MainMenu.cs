using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public Text scoreText;
    public GameObject gameObject;
    private float speedMod = 0.1f;
    private Vector3 point;




    private void Start()
    {
        scoreText.text = PlayerPrefs.GetInt("score").ToString();

        //gameObject = GameObject.Find("ss");
        point = gameObject.transform.position;
        transform.LookAt(point);
    }

    
    public void ToGame()
    {
        SceneManager.LoadScene("Game");
    }

    // Update is called once per frame
    void Update()
    {


        float x = Input.acceleration.x;

        if (Mathf.Abs(x) > 0.15f)
        {
            if (x > 0)
                transform.RotateAround(point, new Vector3(0, 1.0f, 0), 20 * Time.deltaTime * (speedMod + Mathf.Abs(10 * x)));
            else
                transform.RotateAround(point, new Vector3(0, -1.0f, 0), 20 * Time.deltaTime * (speedMod + Mathf.Abs(10 * x)));
        }
        else
            transform.RotateAround(point, new Vector3(0.0f, -1.0f, 0.0f), 20 * Time.deltaTime * speedMod*3);

    }

}
