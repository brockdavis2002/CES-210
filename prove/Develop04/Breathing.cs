using System;

namespace MindfulnessApp
{
    public class Breathing : Activity
    {
        // Method to get the description of the breathing activity
        protected override string GetDescription()
        {
            return "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing folow the timing on screen.";
        }

        // Method to perform the breathing activity
        private void PerformBreathing()
        {
            Animation.Spinner(3); // Display spinner for 3 seconds

            // Let's assume breathe in and out times are both 5 seconds each for demonstration purposes
            int breatheInSeconds = 5;
            int breatheOutSeconds = 5;
            Animation.BreathingAnimation(breatheInSeconds, breatheOutSeconds, Duration); // Custom breathing animation

            Animation.Spinner(2); // Display spinner for 2 seconds
        }

        // Override the StartActivity method to include the breathing performance
        public new void StartActivity()
        {
            base.StartActivity();
            PerformBreathing();
            EndActivity(); // Ensure the activity ends with the proper message
        }
    }
}
