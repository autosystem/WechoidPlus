# What is Wechoid?
`wechoid.exe` is a utility tool associated with the Sentinel RMS (Rights Management System) Licensing System, developed by Thales (formerly Gemalto). This tool plays a crucial role in managing and enforcing software licenses for applications that use the Sentinel RMS system. Here are some key points about `wechoid.exe`:

1. **Purpose**: The primary function of `wechoid.exe` is to generate unique identification information about a user's machine. This information is used to create a fingerprint of the system, which helps in binding software licenses to specific hardware configurations. 

2. **Working Mechanism**: When executed, `wechoid.exe` collects hardware and system information such as the CPU ID, hard drive serial number, network adapter MAC address, and other system components' identifiers. It then generates a unique code (often referred to as a "wechoid" or "lock code") based on this information.

3. **Usage in Licensing**: The unique code generated by `wechoid.exe` is used by software vendors to issue licenses that are locked to a specific machine. This prevents the unauthorized distribution or use of the software on unlicensed machines. When the software is installed, it checks the current system's fingerprint against the license information to verify that it is running on an authorized machine.

4. **Sentinel RMS Integration**: As part of the Sentinel RMS system, `wechoid.exe` integrates with other Sentinel components to provide a comprehensive licensing and rights management solution. This includes license enforcement, usage tracking, and reporting features, ensuring that software usage complies with the vendor's licensing terms.

5. **User Interaction**: End-users or system administrators typically run `wechoid.exe` during the installation or setup of licensed software. The output (the unique identification code) may need to be sent to the software vendor to obtain a valid license key or file.

In summary, `wechoid.exe` is an essential tool within the Sentinel RMS Licensing System, providing a way to bind software licenses to specific hardware configurations and thus helping to enforce licensing policies and protect software from unauthorized use.
# What is WechoidPlus?
This tool has all the features of the official **wechoid.exe** that is usually provided by the [Thales](https://cpl.thalesgroup.com/) Company. But in addition, it gives the ability to save **Locking Criteria** and **Locking Data** in a text file.
<p></p>
<picture>
  <img alt="wechoid window" src="https://github.com/autosystem/WechoidPlus/blob/master/Pic/wechoidplus1.PNG">
</picture>
<p></p>
<picture>
  <img alt="wechoid window" src="https://github.com/autosystem/WechoidPlus/blob/master/Pic/wechoidplus2.PNG">
</picture>
<p></p>
<picture>
  <img alt="wechoid window" src="https://github.com/autosystem/WechoidPlus/blob/master/Pic/wechoidplus3.PNG">
</picture>

# How to Build?
<p></p>Load project solution with visual studio, then build and find compiled version on bin directory.</p>
