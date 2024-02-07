using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookLive.MVVM.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly Random random = new Random();
        public MainViewModel() 
        {
            StartRandomViewerCountSimulation();
        }

        [ObservableProperty]
        int viewerCount;


        private async void StartRandomViewerCountSimulation()
        {
            while (true)
            {
                // Simulate random changes in viewer count
                RandomizeViewerCount();

                // Randomize delay time before the next change
                int delayMilliseconds = random.Next(5000, 15000); // Change every 1 to 5 seconds
                await Task.Delay(delayMilliseconds);
            }
        }

        private void RandomizeViewerCount()
        {
            int currentCount = ViewerCount;
            int targetCount = random.Next(90, 120); // Set your desired maximum viewer count

            // Gradual change with steps
            int step = (targetCount - currentCount) / 10;
            for (int i = 0; i < 10; i++)
            {
                ViewerCount += step;
                Task.Delay(100).Wait(); // Adjust the delay to control the speed of the change
            }

            // Ensure the final count is exactly the target count
            ViewerCount = targetCount;
        }
    }
    
    
}
