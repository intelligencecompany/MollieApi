﻿using System;
using Newtonsoft.Json;

namespace Mollie.Api.Models.Profile.Response {
    public class ProfileResponse : IResponseObject {
        /// <summary>
        /// Indicates the response contains a profile object. Will always contain profile for this endpoint.
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// The identifier uniquely referring to this profile, for example pfl_v9hTwCvYqw.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Indicates whether the payment profile is in test or production mode.
        /// Possible values: live or test
        /// </summary>
        public Mode Mode { get; set; }

        /// <summary>
        /// The payment profile's name, this will usually reflect the tradename or brand name of the profile's website or
        /// application.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The URL to the profile's website or application.
        /// </summary>
        public string Website { get; set; }

        /// <summary>
        /// The email address associated with the profile's tradename or brand.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The phone number associated with the profile's tradename or brand.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// The industry associated with the profile’s trade name or brand. Please refer to the documentation of the business category
        /// for more information on which values are accepted.
        /// </summary>
        public string BusinessCategory { get; set; }
        
        /// <summary>
        /// The industry associated with the profile's tradename or brand. 
        /// </summary>
        [Obsolete("This parameter is deprecated and will be removed in 2022. Please use the businessCategory parameter instead.")]
        public int CategoryCode { get; set; }

        /// <summary>
        /// The profile status determines whether the payment profile is able to receive live payments. See the 
        /// Mollie.Api.Models.Profile.ProfileStatus class for a full list of known values.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The presence of a review object indicates changes have been made that have not yet been approved by Mollie.
        /// Changes to test profiles are approved automatically, unless a switch to a live profile has been requested.
        /// The review object will therefore usually be null in test mode.
        /// </summary>
        public Review Review { get; set; }

        /// <summary>
        /// The payment profile's date and time of creation.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Useful URLs to related resources.
        /// </summary>
        [JsonProperty("_links")]
        public ProfileResponseLinks Links { get; set; }
    }

    public class Review {
        /// <summary>
        /// The status of the requested profile changes. See the Mollie.Api.Models.Profile.ReviewStatus 
        /// class for a full list of known values.
        /// </summary>
        public string Status { get; set; }
    }
}