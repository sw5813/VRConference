using UnityEngine;
using System.Collections;
using System.IO;

public class VidScript : MonoBehaviour
{
	//public Texture2D[] slides = new Texture2D[9];  //this is removed, no need to set the size its auto detected
	private Texture2D[] slides;
	
	private float changeTime         = 0.04f;
	public float framePerSec        = 25f;
	private int currentSlide       = 0;
	private float timeSinceLast = 1.0f;
	
	public string myPath = "/Users/swu/Development/treehacks/VRConference-master/Assets/Resources"; // directory where all the *.jpg files are that need to be animated
	public string extention = "png";      //extension you looking for
	private GUITexture guiTexture;
	
	void Start()
	{
		guiTexture = GetComponent<GUITexture> ();
		Debug.Log ("Finding files....");
		getFiles(); //new added function
		
		if (slides != null)
		{
			//calc the time to change from fps
			changeTime = 1 / framePerSec;
			Debug.Log ("FPS change time is: "+changeTime);
			
			guiTexture.texture      = slides[currentSlide];
			guiTexture.pixelInset     = new Rect(-slides[currentSlide].width/2, -slides[currentSlide].height/2, slides[currentSlide].width, slides[currentSlide].height);
			currentSlide++;
		}
		else
		{
			Debug.Log ("Set reading directory and file type please");
		}
	}
	
	void Update()
	{
		if (slides != null)
		{
			if(timeSinceLast > changeTime  && currentSlide < slides.Length)
			{
				guiTexture.texture = slides[currentSlide];
				guiTexture.pixelInset = new Rect(-slides[currentSlide].width/2, -slides[currentSlide].height/2, slides[currentSlide].width, slides[currentSlide].height);
				timeSinceLast = 0.0f;
				currentSlide++;
			}
			timeSinceLast += Time.deltaTime;
			
			if(currentSlide == slides.Length)
			{
				currentSlide = 0;
			}
		}
	}
	
	internal void getFiles()
	{
		if (System.IO.Directory.Exists(myPath))
		{
			DirectoryInfo dir = new DirectoryInfo(myPath);
			Debug.Log("Looking for files in dir: "+myPath);
			
			FileInfo[] info = dir.GetFiles("*."+extention);
			
			// Get number of files, and set the length for the texture2d array
			int totalFiles =  info.Length;
			slides = new Texture2D[totalFiles];
			
			int i = 0;
			
			//Read all found files
			foreach (FileInfo f in info)
			{
				string filePath = f.Directory + "/" + f.Name;
				Debug.Log("["+i+"] file found: "+filePath);
				
				var bytes     = System.IO.File.ReadAllBytes(filePath);
				var tex         = new Texture2D(1, 1);
				
				tex.LoadImage(bytes);
				slides[i] = tex;
				
				i++;
			}
		}
		else
		{
			Debug.Log ("Directory DOES NOT exist! ");
		}
	}
}