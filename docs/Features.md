## Features
### 🚀 Fast & Easy Setup  
 - The app is **portable**, **lightweight**, and **self-contained**  
 - Setup takes **~5-10 minutes**  
 - Quick setup guide available  

### ⚙️ Simple Configurability  
 - Easy to configure using `config.json`  
 - Things that can be configured:  
   - `Program path`  
   - `Password`  
   - `Notification sound`  
   - `Notification message`  

 **Note:**  
 You don't need to configure the notification sound and message multiple times unless you want different sounds for each app.  

 ### 📈 Easy Scalability  
 - Being **portable** allows usage with multiple programs with **minimum hassle**  
   - Most of the time, you'd only need to change `ProgramPath` and `password` in `config.json`  
   - The `config.json` supports multiple file formats:  
     - **Executable files**: `.exe`  
     - **Shortcuts**: `.lnk`  
     - **Web links**: `URL`  
     - **Media files**: `.mp4`, `.mp3`, `.wav`  
     - **Folders**  

## How does it work
-Here's a simple flowchart explaning the workings of the app
<img src="https://imgur.com/NGj3ZO7.png">

## Core Mechanics 

**Program Launch:**

* If the user clicks a shortcut linked to AppShield, the AppShield password prompt will launch instead of the intended program.
* If the shortcut is the original program's shortcut (not setup with AppShield), the program will start normally.

**Password Verification:**

* The user is presented with the AppShield (GUI) and enters their password.
* AppShield takes the entered password and compares it against the correct password stored within the `config.json` file.

**Incorrect Password:**

* A failed authentication pops up.
* Authentication_Failed.WAV plays along with the notification message.
* The AppShield window automatically closes.

**Correct Password:**

* AppShield successfully verifies the entered password against the one in `config.json`.
* The application then reads the actual file path of the protected program from the `ProgramPath` setting within the `config.json` file.
* Authentication_Success.wavis played.
* AppShield initiates the launch of the original, protected program using the retrieved file path.
* Once the protected program has started, the AppShield application closes itself.
---
-This way app shield is only launched when launching a program its linked with , nullifying any negative effect on system performance. 
-This also makes AppShield verly less intrusive, as it does not have to monitor you system continously to detect when a protected program is being launched.
-The App only runs when its launched othern than it wont run without any user activation.
