namespace BlazorWebApp.Services;

public class UserProfileService
{
    public string ProfileImageUrl { get; private set; } = "https://silicon.blob.core.windows.net/profileimages/avatar.jpg";

    public void SetProfileImageUrl(string url)
    {
        ProfileImageUrl = url;
        OnProfileImageUpdated?.Invoke();
    }

    public event Action OnProfileImageUpdated;

   

}


