 
<h1 align="center">App Shield</h1>

<p align="center"> A simple, straightforward and effective way to password-protect applications on Windows.</p>
<p align="center">
  <a href='https://github.com/adrnjn/App-shield-/blob/main/LICENSE' target="_blank"><img alt='' src='https://img.shields.io/badge/license_-MIT-100000?style=plastic&logo=&logoColor=807979&labelColor=E0EAE2&color=C2ED07'/></a>
  <img src="https://img.shields.io/badge/windows-10%2F11-blue?color=cyan" alt="Windows 10/11">
  <img src="https://img.shields.io/badge/PORTABLE-orange?style=flat&color=21af90" alt="Portable">
  <a href='https://github.com/shivamkapasia0' target="_blank"><img alt='.net' src='https://img.shields.io/badge/.NET_core-100000?style=plastic&logo=.net&logoColor=807979&labelColor=F7F8FD&color=12CAB4'/></a>
  <img src="https://img.shields.io/badge/-100000?style=flat&logo=c#&logoColor=1AD6F7&labelColor=F4F4F4&color=27B30F" alt="C#">
  <a href="https://github.com/adrnjn/App-shield-/blob/main/MainWindow.xaml.cs" target="_blank">
    <img src="https://img.shields.io/badge/Source-available_-100000?style=plastic&logo=&logoColor=1AD6F7&labelColor=383838&color=D33A0F" alt="Source Code">
  </a>
</p>

***

<h2 align="center"> 📌 Introduction</h2>

<p align="center">
Windows does not natively support password protection for individual applications or files. While you can encrypt files using built-in tools like EFS or third-party software, applying passwords to programs typically requires third-party solutions. These solutions often involve system-level modifications or hooks that can impact system performance and security
</p>

<p align="center"> App Shield offers a straightforward workaround</p>
<p align="center">
Instead of directly launching protected applications, users launch App Shield, which acts as a password gate. Upon successful authentication, App Shield then launches the actual application. Using this approach, you can add protection to multiple programs, files, and directories without worrying about performance impact or system instability, as the app only runs when you attempt to launch a protected item.
</p>

 

## 🚀 Fast & Easy Setup  
- The app is **portable**, **lightweight**, and **self-contained**  
- Setup takes **~5-10 minutes**  
- Quick setup guide available  

## ⚙️ Simple Configurability  
- Easy to configure using `config.json`  
- Things that can be configured:  
  - `Program path`  
  - `Password`  
  - `Notification sound`  
  - `Notification message`  

**Note:**  
You don't need to configure the notification sound and message multiple times unless you want different sounds for each app. 

## 📈 Easy Scalability  
- Being **portable** allows usage with multiple programs with **minimum hassle**  
  - Most of the time, you'd only need to change `ProgramPath` and `password` in `config.json`  
  - The `config.json` supports multiple file formats:  
  - **Executable files**: `.exe`  
  - **Shortcuts**: `.lnk`  
  - **Web links**: `URL`  
  - **Media files**: `.mp4`, `.mp3`, `.wav`  
  - **Folders**  



## 🖼 Screenshots

<img src="https://i.imgur.com/KKAL92I.png" alt="app_shield_UI">
<img src="https://i.imgur.com/BKO7oD5.png" alt="app_shield_UI">
<img src="https://i.imgur.com/Hbc0IRD.png" alt="Failed auth">




