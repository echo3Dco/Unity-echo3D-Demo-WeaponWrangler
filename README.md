# Unity-echo3D-Demo-WeaponWrangler
Swap out 3D weapons using a space bar.

## Setup
* Built with [Unity 2021.2.7](https://unity3d.com/get-unity/download/archive) (Note: The echo3D Unity SDK is supported in 2020.3.25 and higher.).
* [Register](https://www.echo3d.com/signup?utm_term={keyword}&utm_campaign=weapons_tutorial&utm_source=medium&utm_medium=blog) for FREE at echo3D.
* [Add the Unity SDK in Unity](https://docs.echo3d.com/unity/installation).
* Clone this repo to view the sample project. The SDK has already been installed. Just upload the models to the echo3D console and add the API key and entry IDs (see below).

## Setup
* Download the 3D model(s) from the Models folder in the project.
* Go to echo3D console and click ["Add to Cloud"](https://docs.echo3d.co/quickstart/add-a-3d-model) and upload the models.
* Open the "SampleScene" scene.
* [Set the API keys](https://docs.echo3d.co/quickstart/access-the-console) for the complimentary asset on the objects in the Hierarchy using the Inspector: Gatling, Sword, Revolver.
<br>![APIKeyandEntryId](https://user-images.githubusercontent.com/99516371/233753895-f131b565-3a5a-4e18-862f-a6017b29f315.png)<br>
![NEWEnterAPIKey](https://user-images.githubusercontent.com/99516371/233753903-247c4b30-7b19-4810-9d39-ecfbfe161791.gif)
* If you have your secret key enabled, [add the security key](https://docs.echo3d.co/web-console/deliver-pages/security-page) for each project to the Global.cs script as well.
* (Recommended) Preview and edit the echo3D asset in real time.
To move, resize or edit the parent object for assets in Scene view, check the boxes for [“Editor Preview”](https://docs.echo3d.com/unity/hologram-script-settings#experimental-editor-preview) and [“Ignore Model Transforms”](https://docs.echo3d.com/unity/hologram-script-settings#ignore-model-transforms) on the echo3D script in Inspector. 
To enable this, click Echo3D > Load Editor Holograms in your Unity toolbar. 

## Run
Press Play in Unity and hit the space bar to swap out the weapons.

## Learn more
Refer to our [documentation](https://docs.echo3D.co/unity/) to learn more about how to use Unity and echo3D.

## Screenshots
![WeaponsGIF](https://user-images.githubusercontent.com/99516371/182254827-8e1e60b4-9e4b-4154-8491-75500e04b7c2.gif)
![Gatling](https://user-images.githubusercontent.com/99516371/182254947-a5c8b8d7-55f3-49fe-bb77-4bb1961f1243.png)<br>
![Gun](https://user-images.githubusercontent.com/99516371/182254950-e74d68bc-b7ea-4720-818f-4726816bd0d3.png)<br>
![Sword](https://user-images.githubusercontent.com/99516371/182254953-7584233a-0305-402e-931e-ee24b031e108.png)<br>

## Support
Feel free to reach out at [support@echo3D.co](mailto:support@echo3D.co) or join our [support channel on Slack](https://go.echo3D.co/join). 
