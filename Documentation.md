****** CREATE A PROJECT *******
- Create 3D URP project 

****** PROJECT SETUP *******
- Install XR Plugin Management (Edit > Project Setting > XR Plugin Management)
- Install OpenXR package (From PC, Mac, Linux & Standalone tab select OpenXR)
- Resolve warnings (Click edit on OpenXR Project validation and make sure to add Oculus Touch Controller Profile in the list   of Interaction Profiles and enable all available OpenXR Feature Groups)
- Enable installation of "Pre-release" (Edit > Project Setting > Package Manager > Enable Pre-release)
- Install XR Interaction Toolkit (Window > Package Manager > Unity Registry > XR Interaction Toolkit)
- Import Starter Assets

****** XR Default Action SETUP *******
- Create XR Input Action Manager (add Input Action Manager component)
- Add XRI Default Input Actions preset in element
- Add each default action preset when you add XR component (Samples > XR Interaction toolkit > Version> Starter)
- Make sure new XR GameObjects use appropriate presets (Project Settings > Preset Manager > ActionBasedController> add Right and left to filter)

****** XR Rig SETUP *******
- Create XR Origin (XR > XR Origin)

****** Configure Other Project Setting *******
- For Andriod (Quest) set Minimum API Level to Android 10
