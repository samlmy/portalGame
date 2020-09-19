using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(MeshCollider collider)
    {
        Destroy(collider.gameObject);
        AddScore();
    }

    void AddScore()
    {
        Score++;
        ScoreText.text = Score.ToString();
    }
}