using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private int dogMax;
    private float wait, forHowLong = 1;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) & dogMax < 1)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogMax ++;
            Debug.Log(dogMax);
        }
        
        if (dogMax > 0)
        {
            Debug.Log("timer started");
            wait += Time.deltaTime;
            if (wait >= forHowLong)
            {
                dogMax --;
                wait = 0;
                Debug.Log("dog reset");
            }
        }
        
        
    }

    // https://www.youtube.com/watch?v=eeY24OyLGv0 tutorial used. code not copied.
    
    
    
    
    /*IEnumerator DogMaxDown()
    {
        if (dogMax > 0)
        {
            yield return new WaitForSeconds(wait);
            dogMax--;
            Debug.Log("dog ready");
        }
    }*/
    //this ^^^ did not work but could work somewhere else
}
