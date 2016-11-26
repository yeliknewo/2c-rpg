using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Ent : Choice {
	public Sprite sprite;

	public override Sprite GetSprite() {
		return sprite;
	}

	public override void Clicked() {
		SetLeft (driver.forest);
		SetRight (driver.forest);
	}
}
