using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBox : MonoBehaviour {

    public bool boxClicked = false;
    public ParticleSystem stars;
    public Animator kebab;

    float speed = 1;
    private float startTime;
    private float journeyLength;
    private float journeyLength2;
    private float journeyLength3;
    private float journeyLength4;

    public Transform startPos1;
    public Transform startPos2;
    public Transform startPos3;
    public Transform startPos4;

    public Transform endPos1;
    public Transform endPos2;
    public Transform endPos3;
    public Transform endPos4;

    public GameObject card1;
    public GameObject card2;
    public GameObject card3;
    public GameObject card4;

    // Use this for initialization
    void Start ()
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(startPos1.position, endPos1.position);
        journeyLength2 = Vector3.Distance(startPos2.position, endPos2.position);
        journeyLength3 = Vector3.Distance(startPos3.position, endPos3.position);
        journeyLength4 = Vector3.Distance(startPos4.position, endPos4.position);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButton(0))
        {
            stars.Play();
            kebab.SetBool("isClicked", true);
            boxClicked = true;
        }

        if (boxClicked)
        {
            DoTheLerp();
        }
	}

    void DoTheLerp()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        float fracJourney2 = distCovered / journeyLength2;
        float fracJourney3 = distCovered / journeyLength3;
        float fracJourney4 = distCovered / journeyLength4;
        card1.transform.position = Vector3.Lerp(startPos1.position, endPos1.position, fracJourney);
        card2.transform.position = Vector3.Lerp(startPos2.position, endPos2.position, fracJourney2);
        card3.transform.position = Vector3.Lerp(startPos3.position, endPos3.position, fracJourney3);
        card4.transform.position = Vector3.Lerp(startPos4.position, endPos4.position, fracJourney4);
    }
}
