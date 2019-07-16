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
    public static RayCastHelper Instance { get; private set; }
    
    [SerializeField] public Camera cam;
    [SerializeField] private GameObject cubik;
    public float score;
    public float hitCounts;
    // Update is called once per frame
    
    public void Awake()
    {
        Instance = this;
    }
    void Update()
    {

        
        
        //     RaycastHit hit = Physics.Raycast(ray.origin, ray.direction);
        //  RaycastHit hit;
        // Physics.Raycast(ray, out hit);
       if (hitCounts >= 4)
        
            hitCounts = 0;
       else
       {



           if (Input.GetKeyDown(KeyCode.Mouse0))
           {



               Ray ray = cam.ScreenPointToRay(Input.mousePosition);
               Debug.DrawRay(ray.origin, ray.direction * 50, Color.yellow);
               RaycastHit hit = new RaycastHit();
               Vector3 fwd = transform.TransformDirection(Vector3.forward);

               if (Physics.Raycast(ray, 20))
               {
                   print("Collided !!!");
                   print(hitCounts);
                   //           print( hit.collider.gameObject.tag);
                   //           if (hit.collider.gameObject.tag == "Cubik")
                   //             Destroy(cubik);
                   score = score + 0.1f;
                   hitCounts = hitCounts + 1;
                   GameObject.FindGameObjectWithTag("ScoreCounter").GetComponent<Text>().text =
                       "Score: " + Mathf.RoundToInt(score).ToString();
                   GameObject.FindGameObjectWithTag("HitCounter").GetComponent<Text>().text =
                       "Hits: " + hitCounts.ToString();

               }
           }
       }



    }
}
