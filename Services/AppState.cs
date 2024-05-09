

namespace Blazor_Test_SK_Mud.Services
{ 
       public class AppState
        {

            
            public event Action? OnChange;

            // Receive 'http' instance from DI
           // private readonly HttpClient http;
            //public AppState()
            //{
            //    // http = httpInstance;
            //}

            public void FilesUploaded()
            {
                NotifyStateChanged();
            }
            private void NotifyStateChanged() => OnChange?.Invoke();
        }
   
}
