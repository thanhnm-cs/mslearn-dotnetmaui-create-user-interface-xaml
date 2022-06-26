using System.Diagnostics;

namespace Notes;

public partial class MainPage : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

    public MainPage()
    {
        InitializeComponent();
        //        MyStackLayout.Padding =
        //    DeviceInfo.Platform == DevicePlatform.iOS
        //? new Thickness(30, 60, 30, 30) // Shift down by 60 points on iOS only
        //        : new Thickness(30); // Set the default margin to be 30 points

        if (File.Exists(_fileName))
        {
            editor.Text = File.ReadAllText(_fileName);
        }
        Debug.Print(_fileName);

    }

    void OnSaveButtonClicked(object sender, EventArgs e)
    {
        File.WriteAllText(_fileName, editor.Text);
    }

    void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        if (File.Exists(_fileName))
        {
            File.Delete(_fileName);
        }
        editor.Text = string.Empty;
    }
}

