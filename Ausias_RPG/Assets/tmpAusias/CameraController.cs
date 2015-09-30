using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {



	#region structs
	public struct BoxLimit{
		public float leftLimit;
		public float rightLimit;
		public float topLimit;
		public float bottomLimit;
	}

	#endregion

	#region class variables
	public static BoxLimit cameraLimits = new BoxLimit();
	public static BoxLimit mouseScrollLimits = new BoxLimit();
	public static CameraController Instance;


	public float sensitivity, cameraMoveSpeed = 60f, radius,minZoom = 10, maxZoom = 100;
	public float mouseBoundary = 25f;
	float mouseX;
	float mouseY;

	bool verticalRotationEnabled = true;
	float verticalRotationMin = 8f;
	float verticalRotationMax = 65f;
	

	[HideInInspector] public float cameraHeight,cameraY;
	float maxCameraHeight = 85f;

	public GameObject mainCamera,scrollAngle;
	
	Transform ausiasTransform;

	#endregion

	void Awake()
	{
		CameraController.Instance = this;
	}
	void Start()
	{


		mouseScrollLimits.leftLimit = mouseBoundary;
		mouseScrollLimits.rightLimit = mouseBoundary;
		mouseScrollLimits.topLimit = mouseBoundary;
		mouseScrollLimits.bottomLimit = mouseBoundary;



		ausiasTransform = GameObject.FindGameObjectWithTag ("Player").transform;
		scrollAngle = new GameObject();

	}
	void Update ()
	{
		if(Input.GetMouseButton(1))
		  {
		transform.RotateAround(ausiasTransform.position,Vector3.up,sensitivity * Time.deltaTime * Input.GetAxis("Mouse X"));
		}
		applyScroll ();

	}

	public void applyScroll()
	{
		float deadZone = 0.01f;
		float easeFactor = 2f;
		float scrollWheelValue = Input.GetAxis ("Mouse ScrollWheel") * easeFactor;

		// check deadZone



		float eulerAngleX = mainCamera.transform.localEulerAngles.x;

		// configure scroll angle 

		scrollAngle.transform.position = transform.position;
		scrollAngle.transform.eulerAngles = new Vector3 (eulerAngleX, this.transform.eulerAngles.y, this.transform.eulerAngles.z);
		scrollAngle.transform.Translate (Vector3.forward * scrollWheelValue);

		Vector3 desiredScrollPosition = scrollAngle.transform.position;

		// update camera

		float heightDifference = desiredScrollPosition.y - this.transform.position.y;
		cameraHeight += heightDifference;
		cameraY = desiredScrollPosition.y;


  		if (desiredScrollPosition.y > 4 || desiredScrollPosition.y < 1.4)
			return;




		this.transform.position = desiredScrollPosition;
		return;



	}
}




























































































