using UnityEngine;

public abstract class Choice : MonoBehaviour {
	public abstract void Clicked ();

	public abstract Sprite GetSprite ();

	protected static Driver driver {
		get {
			return Object.FindObjectOfType<Driver> ();
		}
	}

	protected void SetLeft(Choice choice) {
		driver.leftChoice = choice;
		driver.leftButton.image.sprite = choice.GetSprite();
	}

	protected void SetRight(Choice choice) {
		driver.rightChoice = choice;
		driver.rightButton.image.sprite = choice.GetSprite();
	}
}
