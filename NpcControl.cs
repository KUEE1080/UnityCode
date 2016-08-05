using UnityEngine;
using System.Collections;

public class NpcControl : MonoBehaviour {

	private float h = 0.0f;
	private float v = 0.0f;
	private int timecount = 0;

	private Transform tr;

	public float moveSpeed = 10.0f;
  // 아직 애니메이션 추가 안된 코드
	// Use this for initialization
	void Start () {
		tr = GetComponent<Transform> ();
		h = Random.Range(-1.0f, 1.0f);
		v = Random.Range(-1.0f, 1.0f);
	}

	void Awake()
	{

	}

	// Update is called once per frame
	void Update () {
		timecount++;

		if (timecount % 20 == 0) {
			h = Random.Range(-1.0f, 1.0f);
			v = Random.Range(-1.0f, 1.0f);
		}

		Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);
		tr.Translate (moveDir * Time.deltaTime * moveSpeed, Space.Self);
	}
}
