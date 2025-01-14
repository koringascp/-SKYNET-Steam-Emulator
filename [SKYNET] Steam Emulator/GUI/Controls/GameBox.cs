﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TsudaKageyu;

namespace SKYNET
{
    public partial class GameBox : UserControl
    {
        [Category("SKYNET")]
        public event EventHandler<GameBox> BoxClicked;

        [Category("SKYNET")]
        public Bitmap Image
        {
            get
            {
                return (Bitmap)Avatar.Image;
            }
            set
            {
                Avatar.Image = value;
            }
        }
        [Category("SKYNET")]
        public string GameName
        {
            get
            {
                return _gameName;
            }
            set
            {
                _gameName = value;
                LB_Name.Text = value;
            }
        }
        private string _gameName;

        [Category("SKYNET")]
        public string GamePath
        {
            get
            {
                return _gamePath;
            }
            set
            {
                _gamePath = value;
                if (File.Exists(value))
                {
                    Image = (Bitmap)IconFromFile(_gamePath);
                }
                if (string.IsNullOrEmpty(LB_Name.Text))
                {
                    LB_Name.Text = Path.GetFileNameWithoutExtension(LB_Name.Text);
                }
            }
        }
        private string _gamePath;

        [Category("SKYNET")]
        public uint AppId
        {
            get
            {
                return _appId;
            }
            set
            {
                _appId = value;
            }
        }
        private uint _appId;

        [Category("SKYNET")]
        public string Parametters
        {
            get
            {
                return _parametters;
            }
            set
            {
                _parametters = value;
            }
        }
        private string _parametters;

        [Category("SKYNET")]
        public Color Color
        {
            get
            {
                return _backColor;
            }
            set
            {
                _backColor = value;
            }
        }
        private Color _backColor;

        [Category("SKYNET")]
        public Color Color_MouseHover
        {
            get
            {
                return _Color_MouseHover;
            }
            set
            {
                _Color_MouseHover = value;

            }
        }
        private Color _Color_MouseHover;

        public GameBox()
        {
            InitializeComponent();
            LB_Name.Text = "";
        }

        private void Box_Clicked(object sender, MouseEventArgs e)
        {
            BoxClicked?.Invoke(this, this);
        }
        public static Image IconFromFile(string filePath)
        {
            Image image = null;

            try
            {
                var extractor = new IconExtractor(filePath);
                var icon = extractor.GetIcon(0);

                Icon[] splitIcons = IconUtil.Split(icon);

                Icon selectedIcon = null;

                foreach (var item in splitIcons)
                {
                    if (selectedIcon == null)
                    {
                        selectedIcon = item;
                    }
                    else
                    {
                        if (IconUtil.GetBitCount(item) > IconUtil.GetBitCount(selectedIcon))
                        {
                            selectedIcon = item;
                        }
                        else if (IconUtil.GetBitCount(item) == IconUtil.GetBitCount(selectedIcon) && item.Width > selectedIcon.Width)
                        {
                            selectedIcon = item;
                        }
                    }
                }
                return selectedIcon.ToBitmap();
            }
            catch (Exception)
            {
                
            }

            try
            {
                image = Icon.ExtractAssociatedIcon(filePath)?.ToBitmap();
            }
            catch
            {
                image = new Icon(SystemIcons.Application, 256, 256).ToBitmap();
            }

            return image;
        }

        private void Avatar_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color_MouseHover;
        }

        private void Avatar_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color;
        }
    }
}
