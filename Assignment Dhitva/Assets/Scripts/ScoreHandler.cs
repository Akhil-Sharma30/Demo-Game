using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    [SerializeField]
    public Text scoreHandler;
    public HitManager _hitManager;
    // Start is called before the first frame update
    void Start()
    {
        scoreHandler = GetComponent<Text>();
        GameObject hitManagerObject = GameObject.Find("HitManager"); // find the game object with the HitManager component
    if (hitManagerObject != null)
    {
        _hitManager = hitManagerObject.GetComponent<HitManager>(); // assign the HitManager component to the _hitManager variable
    }
    }

    // Update is called once per frame
    void Update()
    {
        scoreHandler.text = _hitManager.score.ToString();
    }
}
