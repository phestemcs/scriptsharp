// Location.cs
// Script#/Libraries/Web
// Copyright (c) Nikhil Kothari.
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Html {

    [IgnoreNamespace]
    [Imported]
    public sealed class Location {

        private Location() {
        }

        [IntrinsicProperty]
        public string Hash {
            get {
                return null;
            }
            set {
            }
        }

        [IntrinsicProperty]
        public string Hostname {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        [ScriptName("host")]
        public string HostnameAndPort {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        public string Href {
            get {
                return null;
            }
            set {
            }
        }

        [IntrinsicProperty]
        public string Pathname {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        public string Port {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        public string Protocol {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        public string Search {
            get {
                return null;
            }
        }

        /// <summary>
        /// Navigates the window to a new location without updating the browser's history.
        /// </summary>
        /// <param name="url">The URL to navigate to.</param>
        public void Replace(string url) {
        }
    }
}
