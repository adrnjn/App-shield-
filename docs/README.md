 
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
## 📌 Introduction

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

## How is App Shield Different

### A quite Cleaver and simple approach 
App Shield serves as an **intermediary security layer** for launching applications, opening files, and accessing directories. It enforces password protection without modifying system-level settings or interfering with application behavior.  

---

### 🚀 Indirect Launch Mechanism 
Instead of allowing direct access to protected programs and files, App Shield acts as a **gatekeeper**:  
- Users initiate access **through** App Shield rather than launching the target application directly.  
- This ensures **protection is enforced** before access is granted.  

---

### 🔑 Centralized Password Gate 
App Shield establishes a **unified authentication checkpoint** for multiple resources:  
- A **single password prompt** secures multiple applications, files, or folders.  
- Users don’t need to set individual passwords for each protected item.  
- Reduces the risk of **weak, forgotten, or redundant passwords** across different programs.  

---

### 🖥️ Controlled Application Launch
After successful authentication, App Shield **executes the requested action securely**:  
- **Executable files** (`.exe`) are launched only if authentication succeeds.  
- **Individual files** (documents, media, archives) are opened with the default system application.  
- **Entire directories** and their contents are made accessible after verification.  
- Prevents **unauthorized execution of sensitive programs** without password approval.  

---

### ⚡Optimized Performance & Low System Overhead 
Unlike traditional security solutions that constantly monitor system activity, App Shield adopts an **on-demand execution model**:  
- Runs **only when access is attempted**, eliminating unnecessary background processes.  
- Does **not hook into application processes** or modify system files, preserving overall stability.  
- Avoids **continuous CPU or memory usage**, ensuring minimal performance impact.  

---

### 🛡️ Enhanced Stability & Security  
Many third-party application lockers require **deep system integration** or low-level hooks, which can introduce:  
- **Compatibility issues** with Windows updates.  
- **Potential software conflicts** leading to crashes or instability.  
- **Increased attack surface** due to direct modifications of application behavior.  

App Shield mitigates these risks by operating at a **launcher level**, ensuring:  
- **Zero system modifications**, reducing potential security vulnerabilities.  
- **High compatibility** with existing applications and Windows security policies.  
- **Lower risk of corruption or instability** caused by intrusive security layers.  

---  









 





## 🖼 Screenshots

<img src="https://i.imgur.com/KKAL92I.png" alt="app_shield_UI">
<img src="https://i.imgur.com/BKO7oD5.png" alt="app_shield_UI">
<img src="https://i.imgur.com/Hbc0IRD.png" alt="Failed auth">




