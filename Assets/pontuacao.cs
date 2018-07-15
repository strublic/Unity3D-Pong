using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pontuacao : MonoBehaviour {

    public static int ponto1;
    public static int ponto2;

    public Text score1;
    public Text score2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        score1.text = ponto1.ToString();
        score2.text = ponto2.ToString();
    }
}
