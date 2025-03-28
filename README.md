  <p align="center">
  <img src="/Assets/logo.png" alt="App Shield Logo" width="80">
    </p>
 <h2 align="center"> App Shield</h2>

<p align="center"> A simple, straightforward and effective way to password-protect applications on Windows.</p>
<p align="center">
  <a href='https://github.com/adrnjn/App-shield-/blob/main/LICENSE' target="_blank"><img alt='' src='https://img.shields.io/badge/license_-MIT-100000?style=plastic&logo=&logoColor=807979&labelColor=E0EAE2&color=C2ED07'/></a>
  <img src="https://img.shields.io/badge/windows-10%2F11-blue?color=cyan" alt="Windows 10/11">
  <img src="https://img.shields.io/badge/PORTABLE-orange?style=flat&color=21af90" alt="Portable">
  <a href='https://github.com/shivamkapasia0' target="_blank"><img alt='.net' src='https://img.shields.io/badge/.NET_core-100000?style=plastic&logo=.net&logoColor=807979&labelColor=F7F8FD&color=12CAB4'/></a>
  <img src="https://img.shields.io/badge/-100000?style=flat&logo=c#&logoColor=1AD6F7&labelColor=F4F4F4&color=27B30F" alt="C#">
  <a href="/MainWindow.xaml.cs" target="_blank">
    <img src="https://img.shields.io/badge/Source-available_-100000?style=plastic&logo=&logoColor=1AD6F7&labelColor=383838&color=D33A0F" alt="Source Code">
  </a>
</p>

***


<p align="center">
Windows does not natively support password protection for individual applications or files. While you can encrypt files using built-in tools like EFS or third-party software, applying passwords to programs typically requires third-party solutions. These solutions often involve system-level modifications or hooks that can impact system performance and security
</p>

<p align="center"> App Shield offers a straightforward workaround</p>
<p align="center">
Instead of directly launching protected applications, users launch App Shield, which acts as a password gate. Upon successful authentication, App Shield then launches the actual application. Using this approach, you can add protection to multiple programs, files, and directories without worrying about performance impact or system instability, as the app only runs when you attempt to launch a protected item.
</p>

## Key Features
<details>

 **<summary><a href='/MainWindow.xaml.cs' target="_blank"><img alt='' src='https://img.shields.io/badge/Fast_& Easy setup-100000?style=flat-square&logo=&logoColor=1AD6F7&labelColor=565353&color=FF08DA'/></a></summary>**
 *  The app is portable ,Lightweight and self contained.
 *  Setup takes ~ 5-10mins
    * Quick setup guide 
   
    
</details>
<details>

 **<summary><a href='/MainWindow.xaml.cs' target="_blank"><img alt='' src='https://img.shields.io/badge/simple_Configurability-100000?style=flat-square&logo=&logoColor=1AD6F7&labelColor=565353&color=196233'/></a></summary>**
 *  Easy to configure using `config.json`
    ###### Things that can be configured
    * `Program path`
    *  `password`
    * `notification sound`
    * `notification message`


 > <a href='/MainWindow.xaml.cs' target="_blank"><img alt='' src='https://img.shields.io/badge/!_NOTE-100000?style=for-the-badge&logo=&logoColor=1AD6F7&labelColor=565353&color=0776EE'/></a>
>
> you dont have to configure notification sound and message multiple times unless you want to have different notif sound for each app. <sub>[see documentation](https://)</sub>
 

</details>
<details>
    
**<summary><a href='/MainWindow.xaml.cs' target="_blank"><img alt='' src='https://img.shields.io/badge/Easy_scalability-100000?style=flat-square&logo=&logoColor=1AD6F7&labelColor=565353&color=1A30B0'/></a> </summary>**
* being portable gives it the ability to use the app with multiple programs with minimum hassle.(most of the time you'd only need to change `ProgramPath` and password in `config.json`)
    <sub>[see documentation](https://)</sub>
* The `config` supports multiple file formats
    > `exe` , `.ink`(shortcuts), `URL` , `mp4,mp3,wav` , `folders`
</details>

## Installation
- Head over to the Releases page
- Look for the latest release version

## Documentation
<a href='https://adrnjn.github.io/App-shield-/#/' target="_blank"><img alt='' src='https://img.shields.io/badge/Documentation-page-100000?style=flat&logo=&logoColor=807979&labelColor=DD3C02&color=B2B5BD'/></a>

## Screenshots

<img src="https://i.imgur.com/KKAL92I.png" alt="app_shield_UI">
<img src="https://i.imgur.com/BKO7oD5.png" alt="app_shield_UI">
<img src="https://i.imgur.com/Hbc0IRD.png" alt="Failed auth">

## Known Issues
> [!WARNING]
> The app can sometimes take 10-15secs to launch, if system is under a heavy load
> which can delay the launch of the protected app.Tho this has nothing to do with th app itself!





