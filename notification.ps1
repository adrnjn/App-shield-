param(
    [string]$Message # Parameter: The message to display in the notification balloon.
)

# Debug: Output the received message to the console for troubleshooting.
Write-Host "Received message: $Message"

# Check if the message is empty or null.
if ([string]::IsNullOrWhiteSpace($Message)) {
    Write-Host "Error: Message is empty or null"
    exit 1 # Exit with an error code (1) indicating failure.
}

try {
    # Load the System.Windows.Forms assembly to use NotifyIcon.
    Add-Type -AssemblyName System.Windows.Forms

    # Create a new NotifyIcon object (the notification balloon).
    $global:balmsg = New-Object System.Windows.Forms.NotifyIcon

    # Get the path of the current PowerShell process.
    $path = (Get-Process -id $pid).Path

    # Extract the icon from the PowerShell executable and set it for the notification.
    $balmsg.Icon = [System.Drawing.Icon]::ExtractAssociatedIcon($path)

    # Set the notification balloon's icon to information.
    $balmsg.BalloonTipIcon = [System.Windows.Forms.ToolTipIcon]::Info

    # Set the notification balloon's text to the provided message.
    $balmsg.BalloonTipText = $Message

    # Set the notification balloon's title.
    $balmsg.BalloonTipTitle = "Authentication Failed" #this message can be modified 

    # Make the notification balloon visible.
    $balmsg.Visible = $true

    # Play a sound (change the path to your desired sound file).
    $soundPath = "path\to\the\sound\file.wav" # Update this to the sound file you want to play, or use the one inculded with the app(must be .wav)
    $player = New-Object System.Media.SoundPlayer $soundPath

    # Start playing sound asynchronously.
    $player.Play() # Play the sound asynchronously.

    # Debug: Output notification details to the console.
    Write-Host "Showing notification with title: $($balmsg.BalloonTipTitle) and text: $($balmsg.BalloonTipText)"

    # Display the notification balloon for 5000 milliseconds (5 seconds).
    $balmsg.ShowBalloonTip(5000)

    # Pause execution for 6 seconds to keep the notification visible.
    Start-Sleep -Seconds 6

    # Dispose of the NotifyIcon object to release resources.
    $global:balmsg.Dispose()
}
catch {
    # Handle any errors that occur during the notification process.
    Write-Host "An error occurred: $_"
    exit 1 # Exit with an error code (1) indicating failure.
}

# Indicate successful completion of the script.
Write-Host "Notification script completed successfully"
exit 0 # Exit with a success code (0).
