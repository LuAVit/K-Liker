using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayCastHelper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [SerializeField] public Camera cam;
    [SerializeField] private GameObject cubik;
    public int score;
    // Update is called once per frame
    void Update()
    {

        
        
        //     RaycastHit hit = Physics.Raycast(ray.origin, ray.direction);
        //  RaycastHit hit;
        // Physics.Raycast(ray, out hit);
   
          if (Input.GetMouseButtonDown(0))
          {
        
        
        
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 50, Color.yellow);
        RaycastHit hit = new RaycastHit();
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(ray, 20))
        {
            print("Collided !!!");
            print(score);
 //           print( hit.collider.gameObject.tag);
 //           if (hit.collider.gameObject.tag == "Cubik")
   //             Destroy(cubik);
            score = score + 1;
            GameObject.FindGameObjectWithTag ("ScoreCounter").GetComponent<Text>().text = "Score: " + score.ToString();
            
        }
      
        }
        
    }
}
