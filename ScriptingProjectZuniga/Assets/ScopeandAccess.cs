using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeandAccess : MonoBehaviour
{
    public int alpha = 5;

    private int beta = 0;
    private int gamma = 5;

    private AnotherClass myotherClass;


    // Start is called before the first frame update
    void Start()
    {
        alpha = 29;

        myotherClass = new AnotherClass();
        myotherClass.FruitMachine(alpha, myotherClass.apples);
        
    }

    void Example (int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }
    

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}
