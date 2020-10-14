using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickLayerScript : MonoBehaviour
{
	public Transform brick;
	public int numRows, numColumns;
	public float xSpacing, ySpacing, xOrigin, yOrigin;
	public Color[] brickColors;
	public int[] scorePoints = {10,20,30,40,50};

	public static BrickLayerScript S;

    // Start is called before the first frame update
	void Awake()
	{
		S = this;
	}

    void Start()
    {
    	LayBricks(numRows, numColumns);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LayBricks(int numRows, int numColumns)
    {
    	for(int i =0; i < numRows;i++)
    	{
    		for(int j=0; j < numColumns; j++)
    		{
    			Transform t = Instantiate(brick);
    			t.transform.parent = this.transform;
    			Vector2 loc = new Vector2(xOrigin + (i * xSpacing), yOrigin - (j * ySpacing));

    			SpriteRenderer sr = GetComponent<SpriteRenderer>();
    			sr.color = brickColors[j];

    			GameManagerScript.S.AddToTotalBrick();
    			

    			t.transform.position = loc;


    			// Instantiate(brick, new Vector2(0,0), Quanternion.identity);
    		}
    	}
    }
}
