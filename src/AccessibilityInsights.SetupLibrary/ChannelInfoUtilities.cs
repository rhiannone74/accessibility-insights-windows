﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AccessibilityInsights.SetupLibrary
{
    /// <summary>
    /// Utilities to help fetch ChannelInfo objects
    /// </summary>
    public static class ChannelInfoUtilities
    {
        /// <summary>
        /// Given a stream containing a config file, get a specific channel
        /// </summary>
        /// <param name="stream">The stream containing the config file</param>
        /// <param name="keyName">The key name to use when parsing the data</param>
        /// <returns>The valid ChannelInfo</returns>
        public static ChannelInfo GetChannelFromStream(Stream stream, string keyName = "default")
        {
            stream.Position = 0;
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string channelString = reader.ReadToEnd();
            Dictionary<string, ChannelInfo> convertedData = JsonConvert.DeserializeObject<Dictionary<string, ChannelInfo>>(channelString);

            if (convertedData.TryGetValue(keyName, out ChannelInfo channelInfo) &&
                channelInfo.IsValid)
            {
                return channelInfo;
            }

            throw new InvalidDataException("Unable to get ChannelInfo");
        }

        /// <summary>
        /// Given a ReleaseChannel and a keyName, attempt to load the corresponding ChannelInfo objecvt
        /// </summary>
        /// <param name="releaseChannel">The ReleaseChannel being queried</param>
        /// <param name="channelInfo">Returns the ChannelInfo here</param>
        /// <param name="gitHubWrapper">An optional wrapper to the GitHub data</param>
        /// <param name="keyName">An optional override of the key to use when reading the ChannelInfo data</param>
        /// <param name="exceptionReporter">An optional IExceptionReporter if you want exception details</param>
        /// <returns>true if we found data</returns>
        public static bool TryGetChannelInfo(ReleaseChannel releaseChannel, out ChannelInfo channelInfo, IGitHubWrapper gitHubWrapper, string keyName = "default", IExceptionReporter exceptionReporter = null)
        {
            try
            {
                IGitHubWrapper wrapper = gitHubWrapper ?? new GitHubWrapper(exceptionReporter);
                using (Stream stream = new MemoryStream())
                {
                    wrapper.LoadChannelInfoIntoStream(releaseChannel, stream);
                    channelInfo = GetChannelFromStream(stream, keyName);
                    return true;
                }
            }
            catch (Exception e)
            {
                if (exceptionReporter != null)
                {
                    exceptionReporter.ReportException(e);
                }
            }

            // Default values
            channelInfo = null;
            return false;
        }
    }
}
