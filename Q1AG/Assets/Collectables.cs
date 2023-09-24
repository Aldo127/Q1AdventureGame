using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectables : MonoBehaviour
{
    public int evidenceCount;
    public Text evidenceText;
    public GameObject youWin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        evidenceText.text = "Evidence Collected: " + evidenceCount.ToString();

        if(evidenceCount == 6)
        {
            youWin.SetActive(true);
        }
    }
}
