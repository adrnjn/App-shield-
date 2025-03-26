 
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

## Why app Shield

Windows does not natively support password protection for individual applications. While tools like **Encrypting File System (EFS)** and **BitLocker** provide encryption, they do not prompt for a password each time a program or file is accessed.  

### ❌ Windows Limitations  
- **No Built-in App Locking**  
  - Windows lacks a feature to password-protect `.exe` files or require authentication for reopening apps.  
- **EFS & BitLocker**  
  - Encrypt data but do not provide individual file/app password protection once the user is logged in.  
- **User Account Control (UAC)**  
  - Prompts for admin access but does not function as an app-specific lock.  

### ✅ Third-Party Solutions  
- **Application Locker Software**  
  - Monitors and restricts access to apps via password prompts.  
- **Security Suites**  
  - Some antivirus or security tools offer app restriction features.  
- **Virtualization & Sandboxing**  
  - Running apps in a virtual machine can add isolation and password control.  

### ⚠️ Considerations for Third-Party Solutions  
- **Performance Impact**  
  - Background processes can consume resources.  
- **System Stability**  
  - Some solutions may cause conflicts or compatibility issues.  






 App Shield offers a straightforward workaround</p>

Instead of directly launching protected applications, users launch App Shield, which acts as a password gate. Upon successful authentication, App Shield then launches the actual application. Using this approach, you can add protection to multiple programs, files, and directories without worrying about performance impact or system instability, as the app only runs when you attempt to launch a protected item.


 





## 🖼 Screenshots

<img src="https://i.imgur.com/KKAL92I.png" alt="app_shield_UI">
<img src="https://i.imgur.com/BKO7oD5.png" alt="app_shield_UI">
<img src="https://i.imgur.com/Hbc0IRD.png" alt="Failed auth">




