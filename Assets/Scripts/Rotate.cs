using UnityEngine;
using System.Collections;
public class Rotate : MonoBehaviour
{
	void Update()
	{
		//当按着键盘的空格键时，物体就开始围绕自身的x轴进行旋转
		if (Input.GetKey(KeyCode.Space))
		{
			//如果是围绕自身的x轴进行旋转，就是transform.Rotate(new Vector3(1, 0, 0));
			//如果是围绕自身的y轴进行旋转，就是transform.Rotate(new Vector3(0, 1, 0));
			//如果是围绕自身的z轴进行旋转，就是transform.Rotate(new Vector3(0, 0, 1));
			transform.Rotate(new Vector3(0, 0, 0.2f));
		}
	}
}
