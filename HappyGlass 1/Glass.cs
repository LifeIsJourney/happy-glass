using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glass : MonoBehaviour
{   [SerializeField]
    private Sprite suspense,happy, sad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChnageSpriteToSuspense()
    {
        GetComponent<SpriteRenderer>().sprite = suspense;

    } public void ChnageSpriteToHappy()
    {
        GetComponent<SpriteRenderer>().sprite = happy;
    } public void ChnageSpriteToSad()
    {
        GetComponent<SpriteRenderer>().sprite = sad;

    }
}
