﻿//
//  Copyright 2012  Xamarin Inc.
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using FieldService.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using FieldService.WinRT.Utilities;
using Windows.UI.Xaml.Media;

namespace FieldService.WinRT.ViewModels {
    public class PhotoViewModel : FieldService.ViewModels.PhotoViewModel {
        public IEnumerable<Photo> TopPhotos
        {
            get
            {
                if (Photos == null)
                    return null;
                return Photos.Take (3);
            }
        }

        public Photo FirstImage
        {
            get
            {
                if (TopPhotos != null) {
                    return TopPhotos.ElementAtOrDefault (0);
                }
                return null;
            }
        }

        public Photo SecondImage
        {
            get
            {
                if (TopPhotos != null) {
                    return TopPhotos.ElementAtOrDefault (1);
                }
                return null;
            }
        }

        public Photo ThirdImage
        {
            get
            {
                if (TopPhotos != null) {
                    return TopPhotos.ElementAtOrDefault (2);
                }
                return null;
            }
        }

        protected override void OnPropertyChanged (string propertyName)
        {
            base.OnPropertyChanged (propertyName);

            //Make sure property changed is raised for new properties
            if (propertyName == "Photos") {
                OnPropertyChanged ("TopPhotos");
            }
        }
    }
}
