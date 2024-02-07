using FacebookLive.MVVM.ViewModel;

namespace FacebookLive
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        private void CameraView_CamerasLoaded(object sender, EventArgs e)
        {
            camera.Camera = camera.Cameras[1];

            MainThread.BeginInvokeOnMainThread(async () =>
            {
                await camera.StopCameraAsync();
                await camera.StartCameraAsync();
            });
        }
    }

}
