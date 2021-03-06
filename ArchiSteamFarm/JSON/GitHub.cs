﻿/*
    _                _      _  ____   _                           _____
   / \    _ __  ___ | |__  (_)/ ___| | |_  ___   __ _  _ __ ___  |  ___|__ _  _ __  _ __ ___
  / _ \  | '__|/ __|| '_ \ | |\___ \ | __|/ _ \ / _` || '_ ` _ \ | |_  / _` || '__|| '_ ` _ \
 / ___ \ | |  | (__ | | | || | ___) || |_|  __/| (_| || | | | | ||  _|| (_| || |   | | | | | |
/_/   \_\|_|   \___||_| |_||_||____/  \__|\___| \__,_||_| |_| |_||_|   \__,_||_|   |_| |_| |_|

 Copyright 2015-2016 Łukasz "JustArchi" Domeradzki
 Contact: JustArchi@JustArchi.net

 Licensed under the Apache License, Version 2.0 (the "License");
 you may not use this file except in compliance with the License.
 You may obtain a copy of the License at

 http://www.apache.org/licenses/LICENSE-2.0
					
 Unless required by applicable law or agreed to in writing, software
 distributed under the License is distributed on an "AS IS" BASIS,
 WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 See the License for the specific language governing permissions and
 limitations under the License.

*/

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace ArchiSteamFarm.JSON {
	internal static class GitHub {
		[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
		[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Local")]
		internal sealed class ReleaseResponse {
#pragma warning disable 649
			internal sealed class Asset {
				[JsonProperty(PropertyName = "name", Required = Required.Always)]
				internal readonly string Name;

				[JsonProperty(PropertyName = "browser_download_url", Required = Required.Always)]
				internal readonly string DownloadURL;
			}

			[JsonProperty(PropertyName = "tag_name", Required = Required.Always)]
			internal readonly string Tag;

			[JsonProperty(PropertyName = "assets", Required = Required.Always)]
			internal readonly List<Asset> Assets;
#pragma warning restore 649
		}
	}
}
