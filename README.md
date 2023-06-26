# ARBital
Augmented reality chemistry app made in Unity and Vuforia. Motivated by my own struggles learning Chemistry back in Junior College, this app is a Proof-of-Concept project to understand ways to enhance the learning experience using 3D visuals. 

(**Note**: This project is not actively maintained)

## Project Structure

![image](https://github.com/nicholas-gcc/ARBital/assets/69677864/463b1244-f557-401d-b624-aa116f8e0b19)


## Usage
There are three interfaces available on app startup: the Live Camera Feed (Start), instructions interface (Instructions), explanations (Concepts).

![image](https://github.com/nicholas-gcc/ARBital/assets/69677864/80043789-8ad0-42cf-b9af-9befab244495)

### Live Camera Feed
The live camera feed detects unique image markers in the real-world environment and renders 3D interactive animations and models depending on the image marker displayed.

![image](https://github.com/nicholas-gcc/ARBital/assets/69677864/944a6de2-ae14-429c-b8dc-ad69d4b793b4)

When a 3D model is rendered, a size slider is also rendered that enables you to resize the current model being shown. Optionally for some molecules or reactions, virtual buttons are rendered that enable the user to visit a page that explains the concept or pause/play the animation.

### Virtual Buttons
The virtual buttons (Play/Pause and Info buttons) are rendered into the physical environment depending on the chemical structure or reaction being displayed. The virtual buttons respond to physical occlusion on the live camera feed (i.e. put your hands/fingers where the buttons appear), as opposed pressing the button on your device.

![image](https://github.com/nicholas-gcc/ARBital/assets/69677864/a8b4fd92-adb9-4198-9a04-ac5996dc61a5)

### Concepts
Some reaction mechanisms are explained in better detail in the Concepts interface, using textual and visual diagrams (an example below)

![image](https://github.com/nicholas-gcc/ARBital/assets/69677864/e29b8c3f-09ce-4b86-8880-74d8780b8a32)

## Links

Find the **detailed README** [here](https://docs.google.com/document/d/14pPjgsbSOxiqKAuGNLWPKP2D4hK4caRUNchCT-7txVw/edit?usp=sharing)

Find the **product video** [here](https://drive.google.com/file/d/1xPO1QoEIiXFIFlAKlA4xjn_BF8oX8dYi/view?usp=sharing)

Download the **Android APK file** [here](https://github.com/nicholas-gcc/ARBital/releases/download/v1.0/ARbital.apk)
