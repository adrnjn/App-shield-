using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Newtonsoft.Json.Linq;

namespace PasswordApp
{
    public partial class MainWindow : Window
    {
        private string programPath; // Path of the program to be launched
        private string correctPassword; // Correct password for authentication
        private string soundPath; // Path of the sound file to be played
        private string notificationScriptPath; // Path of the PowerShell notification script

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded; // Subscribe to the Loaded event
            LoadConfig(); // Load config on startup
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Password_box.Focus(); // Set focus to the PasswordBox for user input
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close(); // Close the application when the button is clicked
        }

        private void Launch_button_Click(object sender, RoutedEventArgs e)
        {
            AttemptLaunch(); // Call a method to attempt launching the application
        }

        private void Password_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) // Check if Enter key was pressed
            {
                AttemptLaunch(); // Trigger the launch button action
            }
        }

        private void AttemptLaunch()
        {
            // Get the entered password
            string enteredPassword = Password_box.Password; // Retrieve user input from PasswordBox

            // Check if the entered password matches the correct password
            if (enteredPassword == correctPassword)
            {
                PlaySound(soundPath); // Play success sound

                try
                {
                    // Use ProcessStartInfo to launch the specified program
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = programPath,
                        UseShellExecute = true // Use OS shell to open the file
                    };

                    Process.Start(startInfo); // Launch the specified program

                    this.Close(); // Close the password app
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error launching the program: {ex.Message}"); // Show error if launch fails
                }
            }
            else
            {
                // Run the PowerShell script with the notification message
                string message = "Wrong password. The application will not launch.";

                var psi = new ProcessStartInfo
                {
                    FileName = "powershell.exe", // Run PowerShell script
                    Arguments = $"-ExecutionPolicy Bypass -File \"{notificationScriptPath}\" -Message \"{message}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                };
                Process.Start(psi); // Execute the PowerShell script

                this.Close(); // Close the password app
            }
        }

        private void PlaySound(string path)
        {
            try
            {
                using (SoundPlayer player = new SoundPlayer(path))
                {
                    player.PlaySync(); // Play the sound synchronously
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing sound: {ex.Message}"); // Show error if sound fails to play
            }
        }

        private void LoadConfig()
        {
            try
            {
                // Read and parse the configuration file
                string configText = File.ReadAllText("config.json");
                configText = configText.Replace("\\", "/"); // Ensure proper path format

                JObject config = JObject.Parse(configText);
                programPath = config["ProgramPath"].ToString(); // Get the program path
                correctPassword = config["Password"].ToString(); // Get the correct password
                soundPath = config["SoundPath"].ToString(); // Get the sound file path
                notificationScriptPath = config["NotificationScriptPath"].ToString(); // Get the PowerShell script path
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading config: {ex.Message}"); // Show error if config fails to load
                this.Close(); // Close the app if config fails to load
            }
        }
    }
}
