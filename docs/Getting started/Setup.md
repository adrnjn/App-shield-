## Initial setup

* once downloaded unzip the file
* copy the `AppShield v1.0` folder and save it a secure location
    * this folder contains: 
        *  App folder - *cotains main app*
        *  Authentication_Failed.wav - *notif sound for failed auth*
        *  Authentication_Success.wav - *notif sound for successful auth*
        *  Notification.ps1 - Script for failed authentication message


>![Refrence image](https://i.imgur.com/2VPsysQ.png)
>
>
>*this is what the folder structure will look like*
      


---

### Setting up the basics of `config.json`
1. head over to `App` folder.
2. look for `config.json` and open it with a text editor.
   *  your config will look like this:
```
{
  "ProgramPath": "Path:/ to your programs shortcut",
  "Password": "Your desired password",
  "SoundPath": "path:/to/Authentication_Success.wav",
  "NotificationScriptPath": "path:/to/Notification.ps1"
}
```
   * For now leave `ProgramPath` as it is.
    (you can also leave `password` for now if you wish to have diffrent password for each program)

3. now with the config open , copy the path to `Authentication_Success.wav`

   > ![how to copy path](https://i.imgur.com/zuQjVS7.png) 

4. paste it next to `"SoundPath"`
5. do the same for `Notification.ps1`
6. save the config.
    > ![config](https://i.imgur.com/HzLY9hM.png)
    >
    > 
    > *at this stage your config should look like this*


---
### Setting up `Notification.ps1`
1. Go to `Authentication_Failed.wav` and copy its path.
2. now Go to `Notification.ps1`
    - Right click and click on `EDIT` this wil open the powershell ISE
        > ![Edit ps1](https://i.imgur.com/GMekVSg.png)
        >
        > 
        > *dont double click it , this will just run the script*
3. look for `#Play a sound`(use ctrl+F to search for it)
4. paste in the file path of `Authentication_Failed.wav` next to `$soundPath =`
5. save it
    > ![powershell ISE](https://i.imgur.com/2a7EWvQ.png)

<br><br>

> [!TIP]
> once done with basics of the `config.json`. its best to hide `Authentication_Failed.wav` `Authentication_Success.wav` `Notification.ps1`
> just to prevent accidentally deleting or moving them.
> 
> Now you can just copy the config file when using `AppShield` with a new program
and you'd only have to change `ProgramPath"` and `"password"`.


---

## Linking AppShield with programs/files
* once we are done with the basics setup of the config , we can start configuring app shield with programs you want to protect.
    * we will use discord as exmple through out this guide
<br>

1. Search for the app you want to add password protection to `(eg:Dsicord)` in the start menu.
    > *if you have your app on a readily available location like taskbar/ desktop , right click and `open file location`*
2. Right click and open file location. you will be redirected to the apps shortcut file.
3.  use `ctrl+X` to cut the shortcut file 
4.  Paste it in a hidden location on your pc.You can store all the program shortcuts linked with appShield here.
    > you can give it some random name like `SystemCache_Logs` `Telemetry_Reports` `Network_Diagnostics` `Bluetooth_Stack_Dumps` or anything you'd like.
    > you can also change the folder icon `Right click->properties->customize->chance icon`.
    > Hide this folder.

5. After placing it in the folder copy its path.
6. Look for any other shortcuts of that app  `(like on desktop)` and delete them.
7. Open `config.json` and next to `"ProgramPath":` paste the path you just copied.
8. Set your desired password.
9. Save the config.
<br>

* You are almost done.
    * Try launching `AppShield.exe`.
    * Test if everything is workign by inputing wrong and right password.
    * IF you get any error[`config error` `notification error` `program not being launhed`] recheck eveything in the config and ps scrpt and make sure there are no syntax errors.
        *  sometimes you might have to use `\\` inside the program path (eg: instead of `E:\AppShield_v1.0\Authentication_Failed.WAV` use `E:\\AppShield_v1.0\\Authentication_Failed.WAV`)
        *  Config errors ususally give you a warning message during execution idicationg of the error.
        > ![corect config](https://i.imgur.com/jdFBHbf.png)
        >
        > 
        > *this what a correct config should like*

<br>

## Masking AppShield as main shortcut
* once you have made sure the config is correct and it runs properly 
1. right click on`AppShield.exe` and `create shortcut`
2. name the shortcut `discord`
3. place it where the original discort shortcut was before.usually `C:\Users\AppData\Roaming\Microsoft\Windows\Start Menu\Programs` or wherever you want to keep it.
<br>
* **Changing the shortcut's icon**
    * Right click on the shortcut->`properties`->`change icon`->`browse`
    * Navigate to where you have saved the original shortcut or where discord is installed(you can open discord's install location using open file location method on the original shortcut)
    * and just click on the .exe or .ico files present and the shortcut's icon will get updated.
---
* **hide the `config.json`**
     * Hide the config.json by going to `properties`-> `attributes-hidden`
* *rename the `app` folder to the app its linked to `eg: discord` for Easy organisation*
---

 * You are done with the setup, now whenever you launch `eg: discord` you'll be prompted to enter the passwrd firs, and discord will only launch when correct pass is entered.
     > 
     > ![Auth error](https://i.imgur.com/Hbc0IRD.png)
     >
     > 
     > Entering wrong password will display this message
     > accompanied by `Authentication_Failed.wav`

---

## Adding password protection to more than one program/file
* Since we've already set up the config for one app, extending it to others should be quick and easy.
* All we have to do is to change link the new program with the config.json

1. Duplicate the `app` folder 
    - eg: we named out folder discord , when copied it becomes discord-copy
    - rename the copy corresponding to the name of the app/program you are adding password to. (for 2nd eg: chrome).
2. Open `config.json`
3. navigate to where `chrome.ink`(shortcut) exist, follow the step we used to hide discord's original shortcut.(its better to keep all these shortcuts in one folder `eg: inside Network_Diagnostics`)
4. copy path , paste next to `programPath` inside `config.json`. Change `password` if you want to have diffrent password for each program. you can also change notfication,sound etc as to your liking.
    > to chane just clone the notification.ps1 and change the message & sound to whtever you'd like.

5. now just follow the same steps as `Masking AppShield as main shortcut`
6. Repeat for as many apps/programs/files/directories you want.
    > ![eg](https://i.imgur.com/CdelLB6.png)
---

> [!NOTE]
> Inside the`app` Folderes there a subfolder `Settings`.
> The folder contains `access_token.dat` `Auth_config` `auth_data.bin` `Config.xml` `security_key.dat`
> The folder and its content have no fucntion, Its a dummy folder.

> [!ATTENTION]
> If other curious people have acess to your device , and they try to go the file location of the 'masked shortcut' they will come across your `config.json`
through wich they can find the actual location fo your program shrotcut.
to prevent this Its recommended to hide the config.json and a dummy `settings` folder has been created.

> [!TIP]
> Make Sure you note down the location of the secure folder where you have kept your actual program shortcuts.
> To make things easier you can Create AppShield instance with programPath being the directory for the secret folder `eg: "ProgramPath": "E:\\Network_Diagnostics" `

