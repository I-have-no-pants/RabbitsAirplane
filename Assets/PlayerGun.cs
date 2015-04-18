using UnityEngine;
using System.Collections;

public class PlayerGun : MonoBehaviour {

	public Transform target;
	public float reload;
	public float timer;
	public float MaxRotation;
	public TurretScript turret;

	// Use this for initialization
	void Start () {
	
	}
	
	void FixedUpdate () {

		if (timer > 0)
			timer -= Time.fixedDeltaTime;

		// Rotate
		if (target != null) {
			transform.rotation = Quaternion.RotateTowards( transform.rotation, Quaternion.LookRotation( target.transform.position- transform.position, new Vector3(0,1,0)), MaxRotation * Time.fixedDeltaTime);
		}

		if (Input.GetButton("Fire1") && timer <= 0) {
			turret.Fire();
			timer = reload;
		}
		
		
	}
}
