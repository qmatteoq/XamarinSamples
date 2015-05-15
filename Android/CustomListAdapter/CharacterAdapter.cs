using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Koush;
using MarvelPortable.Model;

namespace CustomListAdapter
{
    public class CharacterAdapter: BaseAdapter<Character>
    {
        readonly Activity context;
        readonly List<Character> characters;

        public CharacterAdapter(Activity context, List<Character> characters)
        {
            this.context = context;
            this.characters = characters;
        }

        public override Character this[int position]
        {
            get
            {
                return this.characters[position];
            }
        }

        public override int Count
        {
            get
            {
                return this.characters.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            //Cell reuse...
            var view = convertView;
            if (convertView == null)
            {
                view = this.context.LayoutInflater.Inflate(Resource.Layout.CharacterRow, parent, false);
            }

            var photo = view.FindViewById<ImageView>(Resource.Id.photoImageView);
            var name = view.FindViewById<TextView>(Resource.Id.nameTextView);
            var description = view.FindViewById<TextView>(Resource.Id.specialtyTextView);

            if (this.characters[position].Thumbnail != null)
            {
                UrlImageViewHelper.SetUrlDrawable(photo, this.characters[position].Thumbnail.StandardLargeUri);
            }

            name.Text = this.characters[position].Name;

            string text = this.characters[position].Description;
            if (text.Length > 50)
            {
                text = text.Substring(0, 50) + "...";
            }

            description.Text = text;

            return view;
        }
    }
}