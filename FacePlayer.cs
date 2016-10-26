using UnityEngine;
using System.Collections;

public class FacePlayer : MonoBehaviour
{
	public Camera Target;

	void  Awake ()
	{
		// if no camera referenced, grab the main camera
		if (!Target)
			Target = Camera.main; 
	}

	void  Update ()
	{
		Vector3 targetPostition = new Vector3( 
			Target.transform.position.x, 
			this.transform.position.y,  // lock y rotation so it stays perpedicular
			Target.transform.position.z 
		);
		this.transform.LookAt( 2 * transform.position - targetPostition ) ;
	}
}
