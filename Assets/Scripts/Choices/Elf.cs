using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Elf : Choice {
	public Sprite sprite;

	public override Sprite GetSprite() {
		return sprite;
	}

	public override void Clicked() {
		SetLeft (driver.setup);
		SetRight (driver.setup);
	}
}
