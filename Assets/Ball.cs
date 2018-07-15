using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    float sx;
    float sy;
    private new Rigidbody rigidbody { get { return GetComponent<Rigidbody>(); } }

    bool restartGame = false;

    // Use this for initialization
    void Start () {
		sx = Random.Range(0, 2) == 0 ? -1 : 1;
		sy = Random.Range(0, 2) == 0 ? -1 : 1;
        
        rigidbody.velocity = new Vector3(Random.Range(5, 10) * sx, Random.Range(5, 10) * sy, 0);
    }
	
	// Update is called once per frame
	void Update () {
        if(rigidbody.position.x == 0 && rigidbody.position.y == 0 && restartGame)
        {
            Time.timeScale = 0;
            restartGame = false;
        }

        if(Input.GetButtonDown("Jump") && Time.timeScale == 0)
        {
            Time.timeScale = 1;
            sx = Random.Range(0, 2) == 0 ? -1 : 1;
            sy = Random.Range(0, 2) == 0 ? -1 : 1;
            rigidbody.velocity = new Vector3(Random.Range(5, 10) * sx, Random.Range(5, 10) * sy, 0);
        }

        //if (restartGame && rigidbody.position.x == 0 && rigidbody.position.y == 0)
        //{
        //    sx = Random.Range(0, 2) == 0 ? -1 : 1;
        //    sy = Random.Range(0, 2) == 0 ? -1 : 1;

        //    rigidbody.velocity = new Vector3(Random.Range(5, 10) * sx, Random.Range(5, 10) * sy, 0);
        //    restartGame = false;
        //}
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "paredeDireita" || collision.gameObject.tag == "paredeEsquerda")
        {
            transform.position = new Vector3(0, 0, transform.position.z);
            restartGame = true;
            //Time.timeScale = 0;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "paredeDireita")
        {
            transform.position = new Vector3(0, 0, transform.position.z);
            pontuacao.ponto1++;
            Debug.Log("P1: " + pontuacao.ponto1);
        }
        else if (collision.gameObject.tag == "paredeEsquerda")
        {
            transform.position = new Vector3(0, 0, transform.position.z);
            pontuacao.ponto2++;
            Debug.Log("P2: " + pontuacao.ponto2);;
        }
    }
}
