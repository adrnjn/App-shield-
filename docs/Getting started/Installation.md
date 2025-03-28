## Download


## Initial setup

* once downloaded unzip the file
* copy the `AppShield v1.0` folder and save it a secure location
    * this folder contains: 
        *  App folder - *cotains main app*
        *  Authentication_Failed.wav - *notif sound for failed auth*
        *  Authentication_Success.wav - *notif sound for successful auth*
        *  Notification.ps1 - Script for failed authentication message


![Refrence image](https://i.imgur.com/2VPsysQ.png)

*this is what the folder structure will look like*
      
> [!TIP]
> keep`Authentication_Failed.wav` `Authentication_Success.wav` `Notification.ps1` in the same directory , this way you wont need to copy their file paths eveytime you are linking a new app with AppShield.

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
    (you can also leave`password`for now if you wish to have diffrent password for each program)
