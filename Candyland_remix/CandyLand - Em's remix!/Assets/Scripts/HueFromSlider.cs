/*using UnityEngine;
using UnityEngine.UI;

public class HueFromSlider : MonoBehaviour
{
	public Slider slider;
	public Image player;

	public void Start()
	{
		//Set starting color
		LoadColor();

		//Listen to slider changes
		slider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
	}

	private void LoadColor()
	{
		//Color saved as RGB, convert to get hue value, uses out variables
		Color.RGBToHSV(ActiveUser.Instance.userInfo.color, out float value, out _, out _);
		slider.value = value;

		//Update art color
		player.color = Color.HSVToRGB(slider.value, 0.85f, 0.85f);
	}

	// Invoked when the value of the slider changes.
	public void ValueChangeCheck()
	{
		//Update player/car color
		player.color = Color.HSVToRGB(slider.value, 0.85f, 0.85f);

		//We changed color again quickly, abort save.
		CancelInvoke(nameof(SaveValue));

		//Save after one seccond of no new value
		Invoke(nameof(SaveValue), 1);
	}

	void SaveValue()
	{
		//Update color and then save user to database
		ActiveUser.Instance.userInfo.color = player.color;
		ActiveUser.Instance.SaveUser();
	}
}*/