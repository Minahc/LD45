using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Colonist : MonoBehaviour {
    // Start is called before the first frame update
    public enum Type { Farmer, Builder, Woodcutter };
	public Type type;
	public TileBase[] tilelist;
	public Tilemap details;
	private Vector3 goingto = Vector3.zero*float.NaN;
	public float speed;
	void Start() {
        
    }

    // Update is called once per frame
    void Update() {
		if (type == Type.Woodcutter) {
			if (goingto != goingto) {
				goingto = details.GetComponent<Details>().nearestDetail(transform.position, tilelist[(int)type]);
			}
		}
		transform.position += (goingto - transform.position).normalized*speed;
		//Debug.Log(goingto);
    }
}
