using System;
using System.IO;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Environment = System.Environment;

namespace FilesSample
{
    [Activity(Label = "FilesSample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private string fileName = "MyFile.txt";
        private string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var writeButton = this.FindViewById<Button>(Resource.Id.WriteFilebutton);
            var readButton = this.FindViewById<Button>(Resource.Id.ReadFileButton);
            var text = this.FindViewById<EditText>(Resource.Id.textToSave);
            var label = this.FindViewById<TextView>(Resource.Id.savedText);

            writeButton.Click += (sender, e) =>
            {
                var filePath = Path.Combine(documentsPath, fileName);
                System.IO.File.WriteAllText(filePath, text.Text);
            };

            readButton.Click += (sender, e) =>
            {
                var filePath = Path.Combine(documentsPath, fileName);
                string readText = System.IO.File.ReadAllText(filePath);
                label.Text = readText;
            };

        }
    }
}

